package webdbms.DBMS;

import webdbms.DBMS.database.Database;
import webdbms.DBMS.exception.StorageException;

import java.io.IOException;
import java.util.List;
import java.util.Optional;

public interface Dbms {
    void setDatabases(List<Database> databases);
    void loadDatabaseFromStorage() throws StorageException, IOException;
    void createDatabase(String name) throws StorageException;
    void deleteDatabase(String name) throws StorageException;
    Optional<Database> getDatabase(String name);
    List<Database> getAllDatabases();
}
