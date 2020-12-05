package webdbms.DBMS.database;

import webdbms.DBMS.datatype.DataType;
import webdbms.DBMS.datatype.constraint.RealConstraint;
import webdbms.DBMS.table.Table;
import webdbms.DBMS.exception.StorageException;

import java.io.IOException;
import java.util.List;

public interface Database {

    String getName();
    void setName(String name) throws StorageException;

    void save() throws StorageException;
    void delete() throws StorageException;

    void createTable(String name, List<DataType> types, List<String> columnNames,
                      RealConstraint constraint) throws StorageException;

    void deleteTable(String name) throws StorageException;
    List<Table> getTables();

    void loadTablesFromStorage() throws StorageException, IOException;
}
