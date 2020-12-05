package webdbms.DBMS.exception;

public class EntryException extends StorageException {
    public EntryException(String message) {
        super(message);
    }

    public EntryException(String message, Throwable cause) {
        super(message, cause);
    }

    public EntryException(Throwable cause) {
        super(cause);
    }
}
