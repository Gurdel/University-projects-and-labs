package webdbms.facades;

import webdbms.DBMS.datatype.DataType;
import webdbms.DBMS.datatype.constraint.Constraint;
import webdbms.DBMS.table.Table;

import java.util.List;

public class TableFacade {

    private Table table;

    public TableFacade(Table table) {
        this.table = table;
    }

    public String getTableName() {
        return table.getName();
    }

    public int getNumberOfRows() {
        return table.getEntries().size();
    }

    public List<DataType> getColumnTypes() {
        return table.getTypes();
    }

    public List<String> getColumnNames() {
        return table.getColumnNames();
    }

    public Constraint getRealIntervalConstraint() {
        return table.getConstraint();
    }
}
