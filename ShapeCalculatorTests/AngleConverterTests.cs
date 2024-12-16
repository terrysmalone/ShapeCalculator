using ShapeCalculator;

namespace ShapeCalculatorTests;

public class AngleConverterTests
{
    [TestCase(-1.0, "Angle must be more than zero degrees")]
    [TestCase(0.0, "Angle must be more than zero degrees")]
    [TestCase(361.0, "Angle must 360 degrees or less")]
    [TestCase(1000.0, "Angle must 360 degrees or less")]
    public void TestDegreesToRadiansError(double angle, string expectedErrorMessage)
    {
        Assert.Throws<ArgumentException>(() => AngleConverter.DegreesToRadians(angle)).Message.Equals(expectedErrorMessage);
    }
    public void TestError(double degrees)
    {
        Assert.Throws<ArgumentException>(() => AngleConverter.DegreesToRadians(degrees)).Message.Equals("Radius must be positive");
    }

    [TestCase(180, Math.PI)]
    [TestCase(360.0, 2 * Math.PI)]
    [TestCase(239.5, 4.18006)]
    public void TestDegreesToRadians(double angle, double expected)
    {
        Assert.That(AngleConverter.DegreesToRadians(angle), Is.EqualTo(expected).Within(0.00001));
    }
}