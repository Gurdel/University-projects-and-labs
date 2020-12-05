package webdbms.DBMS.database;

import java.io.File;

public class Databases {

    private Databases() {}

    private final static String REL_DEFAULT_LOCATION = "/src/main/resources/databases/";
    public final static String ABS_DEFAULT_LOCATION = new File("").getAbsolutePath() + REL_DEFAULT_LOCATION;

    static boolean doesDatabaseExist(String name) {
        return doesDatabaseExist(name, ABS_DEFAULT_LOCATION);
    }

    static boolean doesDatabaseExist(String name, String location) {
        File path = new File(location + name);
        return path.isDirectory();
    }
}
