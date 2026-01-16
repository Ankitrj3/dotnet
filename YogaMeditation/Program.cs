public class Program
{
    public static void Main()
    {
        YogaMeditation Y = new YogaMeditation();
        Y.AddYogaMeditation(101, 22, 87.2, 5.6, "Weight Gain");
        Y.AddYogaMeditation(102, 24, 57.2, 5.6, "Weight Loss");
        Y.AddYogaMeditation(103, 25, 67.2, 5.6, "Weight Gain");
        Y.AddYogaMeditation(104, 21, 81.2, 5.6, "Weight Loss");

        Console.WriteLine("Enter The Yoga Meditation ID");
        string? id = Console.ReadLine();
        int ID = int.Parse(id);
        var BMI = Y.CalculateBMI(ID);
        var Fees = Y.CalculateFee(ID);
        Console.WriteLine($"Calculated BMI is "+BMI);
        Console.WriteLine($"Calculated Fees is "+Fees);
    }
}