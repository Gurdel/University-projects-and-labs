package webdbms.DBMS.datatype.constraint;

public class RealConstraint extends Constraint<Double> {

    public RealConstraint() {
        this(Double.MIN_VALUE, Double.MAX_VALUE);
    }

    public RealConstraint(Double minValue, Double maxValue) {
        super(minValue, maxValue);
    }

    public boolean isDefined() {
        return !(Double.MAX_VALUE == maxValue && Double.MIN_VALUE == minValue);
    }
}
