namespace Figure_Geometric.Backend;

public class Trapeze : Triangle
{
    // Field
    private double _d;

    // Property
    public double D
    {
        get { return _d; }
        set
        {
            ValidateD(value);
            _d = value;
        }
    }


    public Trapeze(string name, double a, double b, double c, double d, double h)
        : base(name, a, b, c, h)
    {
        D = d;
    }

    public override double GetArea()
    {
        return (B + D) * H / 2;
    }

    public override double GetPerimeter()
    {
        return A + B + C + D;
    }

    private void ValidateD(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("D must be greater than zero");
        }
    }
}
