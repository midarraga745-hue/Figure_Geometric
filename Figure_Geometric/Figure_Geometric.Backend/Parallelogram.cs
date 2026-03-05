namespace Figure_Geometric.Backend;

public class Parallelogram : Rectangle
{
    // Field
    private double _h;

    // Property
    public double H
    {
        get { return _h; }
        set
        {
            ValidateH(value);
            _h = value;
        }
    }


    public Parallelogram(string name, double a, double b, double h)
        : base(name, a, b)
    {
        H = h;
    }

    public override double GetArea()
    {
        return B * H;
    }

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    private void ValidateH(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("H must be greater than zero");
        }
    }
}
