using ShapeCalculator;

namespace ShapeCalculatorTests;

public class CircleTests
{
    [TestCase(-20.0)]
    [TestCase(-0.5)]
    [TestCase(0.0)]
    public void TestError(double diameter)
    {
        Assert.Throws<ArgumentException>(() => new Circle(diameter)).Message.Equals("Radius must be positive");
    }

    [TestCase(0.15, 0.07069)]
    [TestCase(1.0, 3.14159)]
    [TestCase(7.0, 153.93804)]
    public void TestArea(double radius, double expected)
    {
        Circle circle = new Circle(radius);

        Assert.That(circle.Area, Is.EqualTo(expected).Within(0.00001));
    }

    [TestCase(0.15, 0.94248)]
    [TestCase(1.0, 6.28319)]
    [TestCase(7.0, 43.9823)]
    public void TestPerimeter(double radius, double expected)
    {
        Circle circle = new Circle(radius);

        Assert.That(circle.Perimiter, Is.EqualTo(expected).Within(0.00001));
    }
}