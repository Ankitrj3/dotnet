public class Attributes
{
    [Obsolete("Use the Add(int,int) method instead")]
    public void OldAdd(int a, int b)
    {
        Console.WriteLine(a+b);
    }
    public void Add(int x,int y)
    {
        Console.WriteLine(x+y);
    }
}
public class Program
{
    public static void Main()
    {
        Attributes a = new Attributes();
        a.OldAdd(12,34);
    }
}
