namespace Figure_Geometric.Backend;

public abstract class Figure_Geometric(string name)
{
    // Properties
    public string Name { get; set; }
    public Figure_Geometric(string name)
    {
        Name = name;
    }

    // Methods
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()
    {
        return $"{Name} - Area: {GetArea()}, Perimeter: {GetPerimeter()}";
    }
}
