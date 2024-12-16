namespace ShapeCalculator;

public class Circle : IShape2D
{
    private readonly double _radius;

    public double Area
    {
        get
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
    }

    public double Perimiter
    {
        get
        {
            return 2.0 * Math.PI * _radius;
        }
    }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be positive");
        }

        _radius = radius;
    }
}
