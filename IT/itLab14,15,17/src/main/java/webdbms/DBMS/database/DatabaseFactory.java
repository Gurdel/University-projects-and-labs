package webdbms.DBMS.database;

import webdbms.DBMS.exception.StorageException;

@FunctionalInterface
public interface DatabaseFactory {
    Database getDatabase() throws StorageException;
}
