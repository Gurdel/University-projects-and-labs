package webdbms;

import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.ws.config.annotation.EnableWs;
import webdbms.DBMS.Dbms;
import webdbms.DBMS.DbmsImpl;
import webdbms.controller.*;
import webdbms.DBMS.exception.StorageException;
import webdbms.service.DatabaseService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import webdbms.service.TableService;

import java.io.IOException;
import java.util.ArrayList;

@Configuration
@ComponentScan
@EnableAutoConfiguration
@EnableWs
public class AppConfig {

    @Bean
    public Bootstrap bootstrap() {
        return new Bootstrap();
    }

    @Bean
    public Dbms dbms() throws StorageException, IOException {
        DbmsImpl dbms = new DbmsImpl();
        dbms.setDatabases(new ArrayList<>());
        dbms.loadDatabaseFromStorage();
        return dbms;
    }

    @Bean
    @Autowired
    public DatabaseService databaseService(Dbms dbms) throws StorageException {
        DatabaseService databaseService = new DatabaseService();
        databaseService.setDbms(dbms);
        return databaseService;
    }

    @Bean
    @Autowired
    public TableService tableService(DatabaseService databaseService) throws StorageException {
        TableService tableService = new TableService();
        tableService.setDatabaseService(databaseService);
        return tableService;
    }

    @Bean
    @Autowired
    public DatabaseController databaseController(DatabaseService dbService) {
        DatabaseController databaseController = new DatabaseController();
        databaseController.setDatabaseService(dbService);
        return databaseController;
    }

    @Bean
    @Autowired
    public TableController tableController(DatabaseService databaseService, TableService tableService) {
        TableController tableController = new TableController();
        tableController.setDatabaseService(databaseService);
        tableController.setTableService(tableService);
        return tableController;
    }

    @Bean
    @Autowired
    public EntryController entryController(DatabaseService databaseService, TableService tableService) {
        EntryController entryController = new EntryController();
        entryController.setDatabaseService(databaseService);
        entryController.setTableService(tableService);
        return entryController;
    }

    @Bean
    public TypeController typeController() {
        return new TypeController();
    }
}
