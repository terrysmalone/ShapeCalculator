namespace ShapeCalculator;

internal static class AngleConverter
{
    internal static double DegreesToRadians(double angle)
    {
        if (angle <= 0)
        {
            throw new ArgumentException("Angle must be more than zero degrees");
        }

        if (angle > 360)
        {
            throw new ArgumentException("Angle must be 360 degrees or less");
        }

        return angle * Math.PI / 180.0;
    }
}
