package webdbms.service;

import org.springframework.stereotype.Service;
import webdbms.DBMS.database.Database;
import webdbms.DBMS.datatype.DataType;
import webdbms.DBMS.datatype.constraint.RealConstraint;
import webdbms.DBMS.exception.StorageException;
import webdbms.DBMS.table.Table;
import webdbms.service.exception.TableNotFoundException;
import java.util.List;

@Service
public class TableService {

    private DatabaseService databaseService;

    public void deleteTable(String dbName, String tableName) throws StorageException {
        databaseService.findByName(dbName).deleteTable(tableName);
    }

    public void createTable(String dbName, String tableName, List<DataType> types,
                            List<String> columnNames, RealConstraint constraint) throws StorageException {
        Database db = databaseService.findByName(dbName);
        db.createTable(tableName, types, columnNames, constraint);
        db.save();
    }

    public Table findByName(String dbName, String tableName) throws StorageException {
        Database db = databaseService.findByName(dbName);
        return db.getTables().stream()
                .filter(table -> tableName.equals(table.getName())).findAny()
                .orElseThrow(() -> new TableNotFoundException(dbName, tableName));
    }

    public void setDatabaseService(DatabaseService databaseService) {
        this.databaseService = databaseService;
    }
}
