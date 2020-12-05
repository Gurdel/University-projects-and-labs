package webdbms.controller;

import org.springframework.web.bind.annotation.*;
import webdbms.DBMS.database.Database;
import webdbms.DBMS.entry.Entry;
import webdbms.DBMS.exception.StorageException;
import webdbms.DBMS.table.Table;
import webdbms.facades.EntryFacade;
import webdbms.service.DatabaseService;
import webdbms.service.TableService;
import webdbms.service.exception.InternalServerException;
import webdbms.service.exception.InvalidRequestBodyException;
import java.util.ArrayList;
import java.util.List;
import java.util.Map;

@RestController
@RequestMapping("/databases/{databaseName}/tables/{tableName}/rows")
public class EntryController {

    private DatabaseService databaseService;
    private TableService tableService;

    @SuppressWarnings("unchecked")
    @RequestMapping(value = "/", method = RequestMethod.POST)
    public void addRow(@PathVariable String databaseName, @PathVariable String tableName,
                       @RequestBody Map<String, Object> requestBody) {
        try {
            Database database = databaseService.findByName(databaseName);
            Table table = tableService.findByName(databaseName, tableName);
            String image = requestBody.get("image").toString();
            table.addRow((List<Object>) requestBody.get("values"), image);
            database.save();
        } catch (StorageException e) {
            throw new InternalServerException(e);
        } catch (ClassCastException | NullPointerException e) {
            throw new InvalidRequestBodyException();
        }
    }

    @RequestMapping(value = "/{rowNumber}", method = RequestMethod.DELETE)
    public void deleteRow(@PathVariable String databaseName, @PathVariable String tableName,
                          @PathVariable int rowNumber) {
        try {
            Database database = databaseService.findByName(databaseName);
            List<Entry> entries = tableService.findByName(databaseName, tableName).getEntries();
            if (!isRowNumberValid(entries.size(), rowNumber)) {
                throw new InvalidRequestBodyException();
            }
            tableService.findByName(databaseName, tableName).deleteRow(rowNumber);
            database.save();
        } catch (StorageException e) {
            throw new InternalServerException(e);
        }
    }

    @RequestMapping(value = "/{rowNumber}", method = RequestMethod.GET)
    public EntryFacade getRow(@PathVariable String databaseName,
                              @PathVariable String tableName,
                              @PathVariable int rowNumber) {
        try {
            List<Entry> entries = tableService.findByName(databaseName, tableName).getEntries();
            if (!isRowNumberValid(entries.size(), rowNumber)) {
                throw new InvalidRequestBodyException();
            }
            return new EntryFacade(entries.get(rowNumber));
        } catch (StorageException e) {
            throw new InternalServerException(e);
        }
    }
    private boolean isRowNumberValid(int tableSize, int rowNumber){
        return rowNumber < tableSize && rowNumber >= 0;
    }

    @RequestMapping(value = "/", method = RequestMethod.GET)
    public List<EntryFacade> getRows(@PathVariable String databaseName,
                                     @PathVariable String tableName) {
        List<EntryFacade> entries = new ArrayList<>();
        try {
            tableService.findByName(databaseName, tableName)
                .getEntries().forEach(entry -> entries.add(new EntryFacade(entry)));
            return entries;
        } catch (StorageException e) {
            throw new InternalServerException(e);
        }
    }

    public void setDatabaseService(DatabaseService databaseService) {
        this.databaseService = databaseService;
    }

    public void setTableService(TableService tableService) {
        this.tableService = tableService;
    }
}
