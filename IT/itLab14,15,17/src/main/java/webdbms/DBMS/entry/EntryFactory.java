package webdbms.DBMS.entry;

import webdbms.DBMS.datatype.DataType;
import webdbms.DBMS.datatype.constraint.RealConstraint;
import webdbms.DBMS.exception.EntryException;
import org.json.JSONObject;
import java.util.List;

@FunctionalInterface
public interface EntryFactory {
    Entry getEntryFromJson(JSONObject jsonObject, List<DataType> types, RealConstraint constraint) throws EntryException;
}
