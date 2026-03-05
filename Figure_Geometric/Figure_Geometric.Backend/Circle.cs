namespace Figure_Geometric.Backend;

public class Circle : Figure_Geometric
{
    // Fields

    private double _r;

    // Properties

    public double R
    {
        get { return _r; }
        set
        {
            ValidateR(value);
            _r = value;
        }
    }

    // Methodos

    public Circle(string name, double r) : base(name)
    {
        Name = name;
        R = r;
    }

    public override double GetArea()
    {
        return Math.PI * R * R;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }

    // Methodo Privado
    private void ValidateR(double value)
    {
        if (value <= 0)
        {
            throw new ArgumentException("Radius must be greater than or equal to zero");
        }
    }

}
