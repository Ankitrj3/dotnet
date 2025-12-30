using System.Collections.Generic;
class Program
{
    static void Main()
    {
        var list = new List<byte[]>();

        for(int i = 0; i < 2000; i++)
        {
            list.Add(new byte[1024]);
            // Console.WriteLine(GC.GetTotalMemory(forceFullCollection: false));
        }
        Console.WriteLine("Allocated");

        Console.WriteLine($"Total memory: {GC.GetTotalMemory(forceFullCollection: false)}");
        GC.Collect();
        Console.WriteLine($"Total memory: {GC.GetTotalMemory(forceFullCollection: false)}");
        GC.Collect();
        Console.WriteLine($"Total memory: {GC.GetTotalMemory(forceFullCollection: false)}");
    }
}