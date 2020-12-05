package webdbms.DBMS.database;

import webdbms.DBMS.datatype.constraint.RealConstraint;
import webdbms.DBMS.table.TableImpl;
import webdbms.DBMS.datatype.DataType;
import webdbms.DBMS.exception.DatabaseException;
import webdbms.DBMS.exception.StorageException;
import webdbms.DBMS.exception.TableException;
import webdbms.DBMS.table.Table;
import webdbms.DBMS.table.TableFactory;
import webdbms.DBMS.table.Tables;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class DatabaseImpl implements Database {

    private String name;
    private String location;
    private List<Table> tables;
    private TableFactory tableFactory;

    public DatabaseImpl() throws StorageException {
        this("");
    }

    private DatabaseImpl(String name) throws StorageException {
        this(name, Databases.ABS_DEFAULT_LOCATION);
    }

    private DatabaseImpl(String name, String location) throws StorageException {
        this.name = name;
        this.location = location;
        this.tables = new ArrayList<>();
        this.tableFactory = TableImpl::new;
    }

    @Override
    public void loadTablesFromStorage() throws StorageException, IOException {
        File[] files = new File(this.location + this.name).listFiles();
        for (File entry : files != null ? files : new File[0]) {
            if (entry.isFile()) {
                Table table = tableFactory.getTable().getBuilder()
                        .setName(entry.getName())
                        .setLocation(this.location + this.name + File.separator)
                        .build();
                table.loadDataFromFile();
                tables.add(table);
            }
        }
    }

    @Override
    public void setName(String name) throws DatabaseException {
        if (this.name == null || this.name.equals("")) {
            this.name = name;
        } else {
            throw new DatabaseException("You can not rename the database");
        }
    }

    @Override
    public List<Table> getTables() {
        return tables;
    }

    @Override
    public String getName() {
        return this.name;
    }

    @Override
    public void createTable(String name, List<DataType> types, List<String> columnNames,
                             RealConstraint constraint) throws StorageException {
        Table table = tableFactory.getTable().getBuilder()
                .setName(name)
                .setLocation(this.location + this.name + File.separator)
                .setTypes(types)
                .setColumnNames(columnNames)
                .setConstraint(constraint)
                .build();
        if (tables.contains(table)) {
            throw new TableException("Table with the same name already exists");
        }
        tables.add(table);
    }

    @Override
    public void deleteTable(String name) throws StorageException {
        String tableLocation = this.location + this.name + File.separator;
        Table table = tableFactory.getTable().getBuilder()
                .setName(name)
                .setLocation(tableLocation)
                .build();
        tables.remove(table);
        table.delete();
    }


    @Override
    public void save() throws StorageException {
        if (name.equals("")) {
            throw new DatabaseException("No name is given for the database");
        }
        File path = new File(this.location + this.name);
        if (!Databases.doesDatabaseExist(name) && !path.mkdir()) {
            throw new DatabaseException(String.format("Can not create database on storage %s , %s",this.location, this.name));
        }
        for (Table table : tables) {
            table.writeToFile();
        }
    }

    @Override
    public void delete() throws DatabaseException, TableException {
        if (Databases.doesDatabaseExist(this.name, this.location)) {
            File path = new File(this.location + this.name);
            for (Table table : this.tables) {
                Tables.delete(table.getName(), this.location + this.name + File.separator);
            }
            if (!path.delete()) {
                throw new DatabaseException("Can not delete database from storage");
            }
        } else {
            throw new DatabaseException("Database does not exist on storage");
        }
    }

    @Override
    public String toString() {
        return "Database " + this.name;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof DatabaseImpl)) return false;

        DatabaseImpl database = (DatabaseImpl) o;

        boolean isNamesEquals = name != null ? name.equals(database.name) : database.name == null;
        boolean isLocationsEquals = location != null ? location.equals(database.location) : database.location == null;
        return isNamesEquals && isLocationsEquals;
    }

    @Override
    public int hashCode() {
        int result = name != null ? name.hashCode() : 0;
        result = 31 * result + (location != null ? location.hashCode() : 0);
        return result;
    }
}
