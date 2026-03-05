namespace Figure_Geometric.Backend;

public class Rectangle : Square
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


    public Rectangle(string name, double a, double b)
        : base(name, a)
    {
        B = b;
    }

    public override double GetArea()
    {
        return A * B;
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
