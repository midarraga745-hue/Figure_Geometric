namespace Figure_Geometric.Backend;

public class Kite : Rhombus
{

    // Field
    private double _b;

    // Property
    public double B
    {
        get { return _b; }
        set
        {
            ValidateB(value);
            _b = value;
        }
    }

    // Constructor correcto llamando al base
    public Kite(string name, double a, double d1, double d2, double b)
        : base(name, a, d1, d2)
    {
        B = b;
    }

    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private void ValidateB(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("The value of B must be greater than zero");
        }
    }
}
