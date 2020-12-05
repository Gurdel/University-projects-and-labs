package webdbms.DBMS.entry;

import webdbms.DBMS.datatype.DataType;
import webdbms.DBMS.datatype.constraint.RealConstraint;
import webdbms.DBMS.datatype.TypeManager;
import webdbms.DBMS.exception.EntryException;
import org.json.JSONObject;

import javax.imageio.ImageIO;
import java.awt.image.BufferedImage;
import java.io.ByteArrayOutputStream;
import java.io.IOException;
import java.util.*;
import java.util.List;

public class EntryImpl implements Entry {

    private String image;
    private List<DataType> types;
    private List<Object> values;

    public EntryImpl(List<Object> values, List<DataType> types, RealConstraint constraint) throws EntryException {
        if (types.size() != values.size()) {
            throw new EntryException("Expected types.size() == values.size() but types size == " +
                    types.size() + " and values.size() == " + values.size() + " found");
        }
        for (int column = 0; column < values.size(); column++) {
            if (!TypeManager.instanceOf(values.get(column), types.get(column), constraint)) {
                throw new EntryException("Invalid type in table cell. Expected type " + types.get(column) +
                        " in column " + (column+1) + " but value " + values.get(column) +
                        " (" + values.get(column).getClass() + ") found");
            }
        }
        this.types = types;
        this.values = values;
    }

    public EntryImpl(JSONObject json, List<DataType> types, RealConstraint constraint) throws EntryException {
        this(getValuesFromJson(json), types, constraint);
    }

    private static List<Object> getValuesFromJson(JSONObject json) {
        List<Object> localValues = new ArrayList<>();
        TreeMap<String, Object> jsonMap = new TreeMap<>(Comparator.comparing(Integer::valueOf));
        jsonMap.putAll(json.toMap());
        jsonMap.forEach((key, value) -> localValues.add(value));
        return localValues;
    }

    @Override
    public JSONObject getJson() {
        JSONObject json = new JSONObject();
        for (Integer column = 0; column < this.values.size(); column++) {
            json.put(column.toString(), this.values.get(column));
        }
        return json;
    }

    @Override
    public String getImage() {
        return image;
    }

    @Override
    public void setImage(String image) {
        this.image = image;
    }


    @Override
    public List<Object> getValues() {
        return this.values;
    }

    @Override
    public String toString() {
        return "EntryImpl{" +
                "types=" + types +
                ", values=" + values +
                '}';
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof EntryImpl)) return false;
        EntryImpl entry = (EntryImpl) o;

        boolean typesIsEqual = types != null ? types.equals(entry.types) : entry.types == null;
        boolean valuesIsEqual = values != null ? values.equals(entry.values) : entry.values == null;

        return typesIsEqual && valuesIsEqual;
    }

    @Override
    public int hashCode() {
        int result = types != null ? types.hashCode() : 0;
        result = 31 * result + (values != null ? values.hashCode() : 0);
        return result;
    }
}
