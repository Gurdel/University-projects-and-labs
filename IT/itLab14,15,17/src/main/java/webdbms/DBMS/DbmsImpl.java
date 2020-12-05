package webdbms.DBMS;

import webdbms.DBMS.database.Database;
import webdbms.DBMS.database.DatabaseFactory;
import webdbms.DBMS.database.DatabaseImpl;
import webdbms.DBMS.database.Databases;
import webdbms.DBMS.exception.DatabaseException;
import webdbms.DBMS.exception.StorageException;

import java.io.File;
import java.io.IOException;
import java.util.*;

public class DbmsImpl implements Dbms {

    private List<Database> databases;
    private DatabaseFactory databaseFactory;

    public DbmsImpl() {
        databaseFactory = DatabaseImpl::new;
    }

    @Override
    public void setDatabases(List<Database> databases) {
        this.databases = databases;
    }

    public void loadDatabaseFromStorage() throws StorageException, IOException {
        File[] dirs = new File(Databases.ABS_DEFAULT_LOCATION).listFiles();
        for (File entry : dirs != null ? dirs : new File[0]) {
            if (entry.isDirectory()) {
                Database database = databaseFactory.getDatabase();
                database.setName(entry.getName());
                database.loadTablesFromStorage();
                databases.add(database);
            }
        }
    }

    @Override
    public void createDatabase(String name) throws StorageException {
        Database database = databaseFactory.getDatabase();
        database.setName(name);
        if (databases.contains(database)) {
            throw new DatabaseException("Database with the same name already exists");
        }
        database.save();
        databases.add(database);
    }

    @Override
    public void deleteDatabase(String name) throws StorageException {
        Database db = databases.stream().filter(database -> name.equals(database.getName())).findAny()
            .orElseThrow(() -> new DatabaseException("Database does not exist"));
        db.delete();
        databases.remove(db);
    }

    @Override
    public Optional<Database> getDatabase(String name) {
        for (Database db : databases) {
            if (name.equals(db.getName())){
                return Optional.of(db);
            }
        }
        return Optional.empty();
    }

    @Override
    public List<Database> getAllDatabases() {
        return databases;
    }
}
