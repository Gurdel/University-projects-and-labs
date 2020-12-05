package webdbms.service.exception;

import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.ResponseStatus;

@ResponseStatus(HttpStatus.NOT_FOUND)
public class TableNotFoundException extends PageNotFoundException {
    public TableNotFoundException() {
    }

    public TableNotFoundException(String tableName) {
        super("The table with name " + tableName + " does not exist");
    }

    public TableNotFoundException(String dbName, String tableName) {
        super("The table with name " + tableName + " does not exist in database " + dbName);
    }
}
