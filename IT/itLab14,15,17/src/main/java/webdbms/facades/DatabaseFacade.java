package webdbms.facades;

import webdbms.DBMS.database.Database;

import java.util.ArrayList;
import java.util.List;

public class DatabaseFacade {

    private Database database;

    public DatabaseFacade(Database database) {
        this.database = database;
    }

    public String getDatabaseName() {
        return database.getName();
    }

    public List<String> getTableNames() {
        List<String> names = new ArrayList<>();
        database.getTables().forEach(table -> names.add(table.getName()));
        return names;
    }
}
