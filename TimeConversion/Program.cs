public class Program
{
    public static string TimeConversion(int Time)
    {
        int Hour = Time / 60;
        int Min = Time % 60;
        return $"{Hour}:{Min:F2}";
    }
    public static void Main()
    {
        Console.WriteLine(TimeConversion(134));
    }
}