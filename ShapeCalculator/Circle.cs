using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator;
public class Circle : IShape2D
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("Diameter must be positive");
        }

        _radius = radius;
    }

    public double Area => Math.PI * Math.Pow(_radius, 2);

    public double Perimiter => 2.0 * Math.PI * _radius;
}
