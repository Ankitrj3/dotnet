using Enum1;
using information;
public class Program
{
    public static void Main(string[] args)
    {
        Employee e = new Employee(){Emp_ID=123,Name="ANKIT",Emp_Salary=20000};
        Console.WriteLine(e.Name);
        Console.WriteLine(e.Emp_ID);
        Console.WriteLine(e.Emp_Salary);

        EnumHelper en = new EnumHelper();
        string variableForDay = en.GetWeekDays(WeekDays.Sunday);
        Console.WriteLine(variableForDay);
        Console.WriteLine((int)WeekDays.Monday);
        Console.WriteLine(en.ProductCategory(ProductCategory.Electronics));

        // Console.BackgroundColor(ConsoleColor.Black);
        EnumDays enumDays = new EnumDays();
        enumDays.PrintDays();
    }
}