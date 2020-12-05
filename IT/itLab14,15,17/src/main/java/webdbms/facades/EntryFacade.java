package webdbms.facades;

import webdbms.DBMS.entry.Entry;
import webdbms.DBMS.exception.EntryException;

import java.util.List;

public class EntryFacade {

    private Entry entry;

    public EntryFacade(Entry entry) {
        this.entry = entry;
    }

    public List<Object> getValues() {
        return entry.getValues();
    }

    public String getImage() throws EntryException {
        return entry.getImage();
    }
}
