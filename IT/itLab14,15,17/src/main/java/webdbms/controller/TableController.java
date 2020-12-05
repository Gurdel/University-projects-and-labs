package webdbms.controller;

import org.springframework.web.bind.annotation.*;
import webdbms.DBMS.database.Database;
import webdbms.DBMS.datatype.DataType;
import webdbms.DBMS.datatype.constraint.RealConstraint;
import webdbms.DBMS.entry.Entry;
import webdbms.DBMS.exception.StorageException;
import webdbms.DBMS.table.Table;
import webdbms.facades.DatabaseFacade;
import webdbms.facades.EntryFacade;
import webdbms.facades.TableFacade;
import webdbms.service.DatabaseService;
import webdbms.service.TableService;
import webdbms.service.exception.InternalServerException;
import webdbms.service.exception.InvalidRequestBodyException;

import java.util.*;


@RestController
@RequestMapping("/databases/{databaseName}/tables")
public class TableController {

    private DatabaseService databaseService;
    private TableService tableService;

    @RequestMapping(value = "/", method = RequestMethod.GET)
    public Collection<String> getAllTables(@PathVariable String databaseName) {
        try {
            return new DatabaseFacade(databaseService.findByName(databaseName))
                    .getTableNames();
        } catch (StorageException e) {
            throw new InternalServerException(e);
        }
    }

    @RequestMapping(value = "/{tableName}", method = RequestMethod.GET)
    public TableFacade getTable(@PathVariable String databaseName,
                                @PathVariable String tableName) {
        try {
            Table table = tableService.findByName(databaseName, tableName);
            return new TableFacade(table);
        } catch (StorageException e) {
            throw new InternalServerException(e);
        }
    }

    @SuppressWarnings("unchecked")
    @RequestMapping(value = "/", method = RequestMethod.POST)
    public void createTable(@PathVariable String databaseName,
                            @RequestBody Map<String, Object> requestBody) {
        try {
            String name = requestBody.get("tableName").toString();
            List<DataType> types = getTypesFromObjects((List<Object>) requestBody.get("columnTypes"));
            RealConstraint constraint = getConstraintFromMap((Map) requestBody.get("realIntervalConstraint"));
            List<String> columnNames = getColumnNamesFromObjects((List<Object>) requestBody.get("columnNames"));
            tableService.createTable(databaseName, name, types, columnNames, constraint);
        } catch (ClassCastException | NullPointerException e) {
            throw new InvalidRequestBodyException();
        } catch (StorageException e) {
            throw new InternalServerException(e);
        }
    }


    @RequestMapping(value = "/{tableName}/unique/{searchRow}", method = RequestMethod.GET)
    public List<EntryFacade> renameColumns(@PathVariable String databaseName,
                                     @PathVariable String tableName,
                                           @PathVariable String searchRow) {
        String compare = searchRow;
        List<EntryFacade> entries = new ArrayList<>();

        try {
            List<Entry> entries1 = tableService.findByName(databaseName, tableName).getEntries();
            String temp;
            for (int i = 0; i < entries1.size() - 1; i++) {
                for (int z = 0; z < entries1.get(i).getValues().size(); z++) {
                    System.out.println(entries1.get(i).getValues().get(z));
                    temp = (entries1.get(i).getValues().get(z)).toString();
                    if (temp.contains(compare)) {
                        entries.add(new EntryFacade(entries1.get(i)));
                    }
                }
            }
            return entries;
        } catch (StorageException e) {
            throw new InternalServerException(e);
        }
    }

    private List<DataType> getTypesFromObjects(List<Object> objects) {
        List<DataType> types = new ArrayList<>();
        objects.forEach(type -> types.add(DataType.valueOf(type.toString())));
        return types;
    }

    private RealConstraint getConstraintFromMap(Map<String, Object> map) {
        if (map.get("maxValue") == null && map.get("minValue") == null) {
            return new RealConstraint();
        }
        double maxValue = map.get("maxValue") instanceof Integer ? (int) map.get("maxValue") : (double) map.get("maxValue");
        double minValue = map.get("minValue") instanceof Integer ? (int) map.get("minValue") : (double) map.get("minValue");
        return new RealConstraint(minValue, maxValue);
    }

    private List<String> getColumnNamesFromObjects(List<Object> objects) {
        List<String> names = new ArrayList<>();
        objects.forEach(colName -> names.add(colName.toString()));
        return names;
    }


    public void setDatabaseService(DatabaseService databaseService) {
        this.databaseService = databaseService;
    }

    public void setTableService(TableService tableService) {
        this.tableService = tableService;
    }

    public void deleteRow(String databaseName, String tableName,
                          int rowNumber) {
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

    private boolean isRowNumberValid(int tableSize, int rowNumber) {
        return rowNumber < tableSize && rowNumber >= 0;
    }
}
