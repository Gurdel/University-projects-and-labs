package webdbms.DBMS.entry;

import webdbms.DBMS.datatype.DataType;
import org.json.JSONObject;
import webdbms.DBMS.exception.EntryException;

import java.awt.image.BufferedImage;
import java.util.List;

public interface Entry {

    List<Object> getValues();
    String getImage();

    void setImage(String image);
    JSONObject getJson();
}
