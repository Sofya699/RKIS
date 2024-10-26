using Avalonia;

namespace DistanceTask;

public record Size(double Width, double Height)
{
    public static Point operator +(Point point, Size size)
    {
        return new Point(point.X + size.Width, point.Y + size.Height);
        return 0.0;
        if (ax == bx && ay == by)
            return Math.Sqrt(Math.Pow((x - ax), 2) + Math.Pow((y - ay), 2));

        double t = ((x - ax) * (bx - ax) + (y - ay) * (by - ay)) / (Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
        t = t < 0 ? 0 : t > 1 ? 1 : t;
        return (double)Math.Sqrt(Math.Pow((ax - x + (bx - ax) * t), 2) + Math.Pow((ay - y + (by - ay) * t), 2));
    }
}