package webdbms.controller;

import org.springframework.stereotype.Service;
import org.springframework.web.bind.annotation.*;
import webdbms.DBMS.exception.StorageException;
import webdbms.facades.DatabaseFacade;
import webdbms.service.DatabaseService;
import webdbms.service.exception.InternalServerException;
import webdbms.service.exception.InvalidRequestBodyException;

import java.util.Collection;
import java.util.Map;

@RestController
@RequestMapping("/databases")
public class DatabaseController {

    private DatabaseService databaseService;

    @RequestMapping(value = "/", method = RequestMethod.GET)
    public Collection<String> getDatabaseNames() {
        return databaseService.getDatabaseNames();
    }

    @RequestMapping(value = "/{databaseName}", method = RequestMethod.GET)
    public DatabaseFacade getDatabase(@PathVariable String databaseName) {
        try {
            return new DatabaseFacade(databaseService.findByName(databaseName));
        } catch (StorageException e) {
            throw new InternalServerException(e);
        }
    }

    @RequestMapping(value = "/", method = RequestMethod.POST)
    public void createDatabase(@RequestBody Map<String, String> requestBody) {
        try {
            databaseService.createDatabase(requestBody.get("databaseName"));
        } catch (StorageException e) {
            throw new InternalServerException(e);
        } catch (ClassCastException | NullPointerException e) {
            throw new InvalidRequestBodyException();
        }
    }

    @RequestMapping(value = "/{databaseName}", method = RequestMethod.DELETE)
    public void deleteDatabase(@PathVariable String databaseName) {
        try {
            databaseService.deleteDatabase(databaseName);
        } catch (StorageException e) {
            throw new InternalServerException(e);
        }
    }

    public void setDatabaseService(DatabaseService databaseService) {
        this.databaseService = databaseService;
    }
}
