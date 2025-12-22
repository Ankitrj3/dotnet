

public class Program{

    // This is the sample program 
    // This is use to check the given number is even or odd
    // <param = "num"> Input to check even or odd <param>
    public bool IsEven(int num)
    {
        return num%2 == 0;
    }

    // Main Method of the program
    //<param name = "args"> Command prompt input </param>

    public static void Main(string[] args){
        // Input and Declaration
        Program pro = new Program();
        Console.WriteLine("Enter the Number to find even or odd (q to Quit)\n");
        string? choice = Console.ReadLine();
        bool checkResults = false;
        string output = string.Empty;
        int number = 0;

        // Process and Output
        while (choice != "q" && choice != "Q")
        {
                number = int.TryParse(choice, out number) ? number : 0;
                checkResults = pro.IsEven(number);
                output = checkResults ? "Even" : "Odd";
                Console.WriteLine(output);

                Console.WriteLine("Enter the Number to find even or odd (q to Quit)\n");
                choice = Console.ReadLine();
        }
    }
}