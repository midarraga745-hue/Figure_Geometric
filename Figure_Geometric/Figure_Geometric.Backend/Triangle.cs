

namespace Figure_Geometric.Backend;

public class Triangle : Rectangle
{
    // Fields
    private double _c;
    private double _h;

    // Properties
    public double C
    {
        get { return _c; }
        set
        {
            ValidateC(value);
            _c = value;
        }
    }

    public double H
    {
        get { return _h; }
        set
        {
            ValidateH(value);
            _h = value;
        }
    }

    // Methods
    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    {
        Name = name;
        C = c;
        H = h;

    }


    public override double GetArea()
    {
        return (B * H) / 2;
    }


    public override double GetPerimeter()
    {

        return A + B + C;
    }

    private void ValidateC(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("C must be greater than zero");
        }
    }


    private void ValidateH(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("H must be greater than zero");
        }
    }
}
