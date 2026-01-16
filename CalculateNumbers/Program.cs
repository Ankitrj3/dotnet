using GPA;

public class Program
{
    public static void Main()
    {
        CalculateGPA gpa = new CalculateGPA();
        Console.WriteLine("Enter the how Many numbers you want to enter");
        string? number = Console.ReadLine();
        int n = int.Parse(number);

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the marks");
            string? marks = Console.ReadLine();
            int m = int.Parse(marks);
            gpa.AddMarks(m);
        }
        double getGPA = gpa.GetGPAScored();

        char Grade = gpa.GetGradeScored(getGPA);

        if (Grade.Equals('\0'))
        {
            Console.WriteLine("Invalid GPA");
        }
        Console.WriteLine(Grade);
    }
}