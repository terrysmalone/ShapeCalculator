using ShapeCalculator;

namespace ShapeCalculatorTests;

public class CircleSectorTests
{
    [TestCase(-20.0, 90.0, "Radius must be positive")]
    [TestCase(0.0, 90.0, "Radius must be positive")]
    [TestCase(10.0, -1.0, "Angle must be more than zero degrees")]
    [TestCase(100.0, 0.0, "Angle must be more than zero degrees")]
    [TestCase(15.0, 361.0, "Angle must 360 degrees or less")]
    [TestCase(0.1, 1000.0, "Angle must 360 degrees or less")]
    public void TestError(double diameter, double angle, string expectedErrorMessage)
    {
        Assert.Throws<ArgumentException>(() => new CircleSector(diameter, angle)).Message.Equals(expectedErrorMessage);
    }

    [TestCase(10.0, 180.0, 157.07963)]
    [TestCase(0.45, 241.3, 0.42641)]
    [TestCase(7.0, 360.0, 153.93804)]
    public void TestArea(double radius, double angle, double expected)
    {
        CircleSector circle = new CircleSector(radius, angle);

        Assert.That(circle.Area, Is.EqualTo(expected).Within(0.00001));
    }

    [TestCase(7.0, 360.0, 57.98229)] // Full circle
    [TestCase(7.0, 90.0, 24.99557)]
    [TestCase(2.3, 273.6, 15.58300)]
    public void TestPerimeter(double radius, double angle, double expected)
    {
        CircleSector circle = new CircleSector(radius, angle);

        Assert.That(circle.Perimiter, Is.EqualTo(expected).Within(0.00001));
    }
}