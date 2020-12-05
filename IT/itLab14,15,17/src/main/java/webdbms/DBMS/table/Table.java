package webdbms.DBMS.table;

import webdbms.DBMS.datatype.DataType;
import webdbms.DBMS.entry.Entry;
import webdbms.DBMS.datatype.constraint.RealConstraint;
import webdbms.DBMS.exception.StorageException;
import webdbms.DBMS.exception.TableException;

import java.awt.image.BufferedImage;
import java.io.IOException;
import java.util.List;

public interface Table {

    interface Builder {

        Builder setName(String name);

        Builder setLocation(String location);

        Builder setTypes(List<DataType> dataTypes);

        Builder setColumnNames(List<String> names);

        Builder setConstraint(RealConstraint constraint);

        Table build() throws StorageException;
    }

    String getName();
    List<DataType> getTypes();

    void delete() throws TableException;

    List<String> getColumnNames();

    List<Entry> getEntries();

    void addRow(List<Object> values, String image) throws StorageException;

    void changeColumnName(List<String> names);

    default void deleteRow(int rowNumber) {
        throw new UnsupportedOperationException();
    }

    void sort(int fieldNumber);

    void writeToFile() throws StorageException;

    RealConstraint getConstraint();

    void loadDataFromFile() throws StorageException, IOException;

    String getLocation();

    TableImpl.Builder getBuilder() throws StorageException;

    boolean isEmpty();
}
