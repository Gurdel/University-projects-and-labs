package webdbms.DBMS.table;

import webdbms.DBMS.exception.TableException;

import java.io.File;

public class Tables {

    static boolean doesTableExist(String name, String location) {
        File table = new File(location + name);
        return table.isFile();
    }

    public static void delete(String name, String location) throws TableException {
        if (doesTableExist(name, location)) {
            File table  = new File(location + name);
            if(!table.delete()) {
                throw new TableException("Can not delete table from storage");
            }
        }
    }
}
