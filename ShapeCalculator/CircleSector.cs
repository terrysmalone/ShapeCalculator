namespace ShapeCalculator;

public class CircleSector : IShape2D
{
    private readonly double _radius;
    private readonly double _angle;

    public double Area
    {
        get
        {
            return Math.PI * Math.Pow(_radius, 2) * (_angle / 360.0);
        }
    }

    public double Perimiter
    {
        get
        {
            return _radius + _radius + (_radius * AngleConverter.DegreesToRadians(_angle));
        }
    }

    // A circular sector with angles in degrees
    public CircleSector(double radius, double angle)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Radius must be positive");
        }

        if (angle <= 0)
        {
            throw new ArgumentException("Angle must be more than zero degrees");
        }

        if (angle > 360)
        {
            throw new ArgumentException("Angle must be 360 degrees or less");
        }

        _radius = radius;
        _angle = angle; 
    }
}