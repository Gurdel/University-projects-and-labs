package webdbms.DBMS.table;

import webdbms.DBMS.datatype.TypeManager;
import webdbms.DBMS.entry.Entry;
import webdbms.DBMS.entry.EntryFactory;
import webdbms.DBMS.entry.EntryImpl;
import webdbms.DBMS.datatype.constraint.RealConstraint;
import webdbms.DBMS.exception.StorageException;
import webdbms.DBMS.datatype.DataType;
import webdbms.DBMS.exception.EntryException;
import webdbms.DBMS.exception.TableException;
import org.json.*;
import java.io.*;
import java.util.*;
import java.util.stream.Collectors;

public class TableImpl implements Table {

    private RealConstraint constraint;
    private String location;
    private String name;
    private List<DataType> types;
    private List<String> columnNames;
    private List<Entry> entries;
    private EntryFactory entryFactory;

    public TableImpl() throws StorageException {
        this.entries = new ArrayList<>();
        this.types = new ArrayList<>();
        this.columnNames = new ArrayList<>();
        this.constraint = new RealConstraint();
        this.entryFactory = EntryImpl::new;
    }

    @Override
    public Builder getBuilder() throws StorageException {
        return this.new BuilderImpl();
    }

    class BuilderImpl implements Builder {

        @Override
        public Builder setName(String name) {
            TableImpl.this.name = name;
            return this;
        }

        @Override
        public Builder setLocation(String location) {
            TableImpl.this.location = new File(location).getAbsolutePath() + File.separator;
            return this;
        }

        @Override
        public Builder setTypes(List<DataType> dataTypes) {
            TableImpl.this.types = dataTypes;
            return this;
        }

        @Override
        public Builder setColumnNames(List<String> names) {
            TableImpl.this.columnNames = names;
            return this;
        }

        @Override
        public Builder setConstraint(RealConstraint constraint) {
            TableImpl.this.constraint = constraint;
            return this;
        }

        @Override
        public Table build() throws StorageException {
            if (name == null || name.equals("") || location == null) {
                throw new TableException("Required name and location");
            }
            return TableImpl.this;
        }
    }

    @Override
    public void loadDataFromFile() throws StorageException, IOException {
        String rowInFile = new JSONArray().toString();
        String readData = rowInFile + '\n' + rowInFile + '\n' + rowInFile + '\n' + rowInFile + '\n' + rowInFile;
        if (Tables.doesTableExist(this.name, this.location)) {
            readData = readTableFromStorage(this.location + this.name);
        }
        String[] s = readData.split("\n");
        List<DataType> readTypes = new ArrayList<>();
        for (Object title : new JSONArray(s[0]).toList()) {
            columnNames.add(title.toString());
        }
        new JSONArray(s[1]).toList().forEach(type -> readTypes.add(DataType.valueOf(type.toString())));
        JSONArray constraints = new JSONArray(s[3]);
        if (constraints.length() != 0) {
            this.constraint = new RealConstraint(constraints.getDouble(0), constraints.getDouble(1));
        }
        JSONArray imageJson = new JSONArray(s[4]);
        if (this.types.equals(readTypes) || types.isEmpty()) {
            this.types = readTypes;
            this.entries = getEntriesFromJson(new JSONArray(s[2]), readTypes);
            for (int i = 0; i < entries.size(); i++) {
                this.entries.get(i).setImage(imageJson.get(i).toString());
            }
        } else {
            throw new TableException("Expected types " + readTypes + " but " + this.types + " found");
        }
    }

    private String readTableFromStorage(String storageLocation) {
        try (BufferedReader reader = new BufferedReader(new FileReader(storageLocation))) {
            return reader.readLine() + '\n' + reader.readLine() + '\n' + reader.readLine() + '\n' + reader.readLine() + '\n' + reader.readLine();
        } catch (IOException e) {
            throw new RuntimeException("Can not read table from storage", e);
        }
    }

    private List<Entry> getEntriesFromJson(JSONArray jsonArray, List<DataType> types) throws EntryException {
        List<Entry> entries = new ArrayList<>();
        for (Object json : jsonArray) {
            JSONObject jsonObject = (JSONObject)json;
            Entry entry = entryFactory.getEntryFromJson(jsonObject, types, constraint);
            entries.add(entry);
        }
        return entries;
    }

    @Override
    public boolean isEmpty() {
        return this.entries.isEmpty();
    }

    @Override
    public void writeToFile() throws StorageException {
        if (this.name.equals("") || this.location.equals("") ) {
            throw new TableException("Expected defined name, location and types");
        }
        try (BufferedWriter writer = new BufferedWriter(new FileWriter(this.location + this.name))) {
            writer.write(new JSONArray(this.columnNames).toString() + "\n");
            writer.write(new JSONArray(this.types).toString() + "\n");
            writer.write(this.getJsonArray().toString() + "\n");
            JSONArray constraints = new JSONArray();
            if (constraint.isDefined()) {
                constraints.put(this.constraint.getMinValue());
                constraints.put(this.constraint.getMaxValue());
            }
            writer.write(constraints.toString() + "\n");
            JSONArray images = new JSONArray();
            entries.forEach(entry -> images.put(entry.getImage()));
            writer.write(images.toString());
            writer.flush();
        } catch (IOException e) {
            throw new RuntimeException("Can not write table to storage", e);
        }
    }

    private JSONArray getJsonArray() throws EntryException {
        JSONArray jsonArray = new JSONArray();
        for (Entry entry : this.entries) {
            jsonArray.put(entry.getJson());
        }
        return jsonArray;
    }

    @Override
    public void addRow(List<Object> values, String image) throws StorageException {
        if (values.size() != types.size()) {
            throw new TableException("Expected " + types.size() + " values but " + values.size() + " found");
        }
        for (int i = 0; i < values.size(); i++) {
            if(values.get(i) instanceof String) {
                try {
                    values.set(i, TypeManager.parseObjectByType(values.get(i).toString(), types.get(i)));
                } catch (NumberFormatException e) {
                    throw new TableException("Invalid value " + values.get(i));
                }
            }
        }
        Entry entry = new EntryImpl(values, types, constraint);
        if (image != null) {
            entry.setImage(image);
        }
        entries.add(entry);
    }

    @Override
    public void changeColumnName(List<String> names) {
        this.columnNames = names;
    }

    @Override
    public void deleteRow(int rowNumber) {
        entries.remove(rowNumber);
    }

    @Override
    public void sort(int fieldNumber) {
        entries.sort(new Comparator<Entry>() {
            @Override
            @SuppressWarnings("unchecked")
            public int compare(Entry entry1, Entry entry2) {
                Comparable cmp1 = getComparableElement(entry1);
                Comparable cmp2 = getComparableElement(entry2);
                return cmp1.compareTo(cmp2);
            }
            private Comparable getComparableElement(Entry entry) {
                Comparable field = (Comparable)entry.getValues().get(fieldNumber);
                return (field instanceof Character || field instanceof String) ? field.toString().toLowerCase() : field;
            }
        });
    }

    @Override
    public void delete() throws TableException {
        Tables.delete(name, location);
    }

    @Override
    public List<String> getColumnNames() {
        return columnNames;
    }

    @Override
    public List<Entry> getEntries() {
        return entries;
    }

    @Override
    public String getName() {
        return this.name;
    }

    @Override
    public List<DataType> getTypes() {
        return this.types;
    }

    @Override
    public String getLocation() {
        return location;
    }

    @Override
    public RealConstraint getConstraint() {
        return constraint;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof TableImpl)) return false;

        TableImpl table = (TableImpl) o;

        return (location != null ? location.equals(table.location) : table.location == null) &&
                (name != null ? name.equals(table.name) : table.name == null);
    }

    @Override
    public int hashCode() {
        int result = location != null ? location.hashCode() : 0;
        result = 31 * result + (name != null ? name.hashCode() : 0);
        return result;
    }
}
