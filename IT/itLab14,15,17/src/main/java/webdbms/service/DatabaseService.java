package webdbms.service;

import org.springframework.stereotype.Service;
import webdbms.DBMS.Dbms;
import webdbms.DBMS.database.Database;
import webdbms.DBMS.exception.StorageException;
import webdbms.service.exception.DatabaseNotFoundException;

import java.util.ArrayList;
import java.util.Collection;
import java.util.List;

@Service
public class DatabaseService {
    private Dbms dbms;

    public DatabaseService() {
    }

    public void deleteDatabase(String name) throws StorageException {
        dbms.deleteDatabase(name);
    }

    public void createDatabase(String name) throws StorageException {
        dbms.createDatabase(name);
    }

    public Collection<String> getDatabaseNames() {
        List<String> databaseNames = new ArrayList<>();
        dbms.getAllDatabases().forEach(database -> databaseNames.add(database.getName()));
        return databaseNames;
    }

    public Database findByName(String name) throws StorageException {
        return dbms.getAllDatabases().stream()
                .filter(db -> name.equals(db.getName())).findAny()
                .orElseThrow(() -> new DatabaseNotFoundException(name));
    }

    public void setDbms(Dbms dbms) {
        this.dbms = dbms;
    }
}
