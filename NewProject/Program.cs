
/// <summary>
/// NewProject - A console application demonstrating even/odd number checking
/// This program continuously checks if entered numbers are even or odd until user quits
/// </summary>
public class Program{

    /// <summary>
    /// Checks if a given number is even or odd
    /// </summary>
    /// <param name="num">The integer number to check</param>
    /// <returns>True if the number is even, false if odd</returns>
    // This is the sample program 
    // This is use to check the given number is even or odd
    // <param = "num"> Input to check even or odd <param>
    public bool IsEven(int num)
    {
        // Use modulo operator to check divisibility by 2
        // If remainder is 0, number is even
        return num%2 == 0;
    }

    /// <summary>
    /// Main entry point of the application
    /// Implements a continuous loop for even/odd checking until user enters 'q'
    /// </summary>
    /// <param name="args">Command line arguments (not used in this program)</param>
    // Main Method of the program
    //<param name = "args"> Command prompt input </param>

    public static void Main(string[] args){
        // Input and Declaration
        Program pro = new Program(); // Create instance to call non-static method
        Console.WriteLine("Enter the Number to find even or odd (q to Quit)\n");
        string? choice = Console.ReadLine(); // Read initial user input
        bool checkResults = false; // Store the result of even/odd check
        string output = string.Empty; // Store the output message
        int number = 0; // Store the parsed number

        // Process and Output - Continue until user enters 'q' or 'Q'
        while (choice != "q" && choice != "Q")
        {
                // Try to parse input as integer, default to 0 if parsing fails
                number = int.TryParse(choice, out number) ? number : 0;
                
                // Check if the number is even using our IsEven method
                checkResults = pro.IsEven(number);
                
                // Set output message based on the result using ternary operator
                output = checkResults ? "Even" : "Odd";
                Console.WriteLine(output);

                // Prompt for next input
                Console.WriteLine("Enter the Number to find even or odd (q to Quit)\n");
                choice = Console.ReadLine();
        }
    }
}