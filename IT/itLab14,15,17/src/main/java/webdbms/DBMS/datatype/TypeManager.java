package webdbms.DBMS.datatype;

import webdbms.DBMS.datatype.constraint.RealConstraint;

import java.util.regex.Pattern;

public class TypeManager {

    public static boolean instanceOf(Object object, DataType dataType) {
        switch (dataType) {
            case INTEGER:
                return object instanceof Integer;
            case CHAR:
                return Pattern.matches(".?", object.toString());
            case REAL:
            case INTEGER_INTERVAL:
                return object instanceof Double || object instanceof Integer;
            case FILE:
                return object instanceof String ;
            default:
                return false;
        }
    }

    public static boolean instanceOf(Object object, DataType dataType, RealConstraint constraint) {
        if (dataType == DataType.INTEGER_INTERVAL) {
            if (object instanceof Integer) {
                object = Double.valueOf((Integer)object);
            }
            return object instanceof Double && constraint.isValueValid((Double) object);
        } else {
            return instanceOf(object, dataType);
        }
    }

    public static Object parseObjectByType(String object, DataType dataType) throws NumberFormatException {
        switch (dataType) {
            case INTEGER:
                return Integer.valueOf(object);
            case CHAR:
                return object.charAt(0);
            case REAL:
            case INTEGER_INTERVAL:
                return Double.valueOf(object);
            case FILE:
                return String.valueOf(object);
            default:
                throw new NumberFormatException("Unknown data format");
        }
    }
}
