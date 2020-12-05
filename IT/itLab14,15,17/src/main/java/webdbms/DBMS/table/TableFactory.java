package webdbms.DBMS.table;

import webdbms.DBMS.exception.StorageException;

@FunctionalInterface
public interface TableFactory {
    Table getTable() throws StorageException;
}
