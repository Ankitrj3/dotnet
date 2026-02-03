public class Program
{
    public static double AreaOfCircle(double radius)
    {
        double area = Math.PI * radius * radius;
        return Math.Round(area, 2, MidpointRounding.AwayFromZero);
    }
    public static void Main()
    {
        double r = 2.4;
        Console.WriteLine(AreaOfCircle(r));
    }
}