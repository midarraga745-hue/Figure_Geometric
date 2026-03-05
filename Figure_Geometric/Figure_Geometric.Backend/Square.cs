namespace Figure_Geometric.Backend;

public class Square : Figure_Geometric
{
    // Fields
    private double _a;


    // Properties
    public double A
    {
        get { return _a; }
        set
        {
            ValidateA(value);
            _a = value;
        }
    }


    public Square(string name, double a) : base(name)
    {
        Name = name;
        A = a;
    }

    public override double GetArea()
    {
        return A * A;
    }

    public override double GetPerimeter()
    {
        return 4 * A;
    }

    private void ValidateA(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("The side must be greater than zero");
        }
    }
}
