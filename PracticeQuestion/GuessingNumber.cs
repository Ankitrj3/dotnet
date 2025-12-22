/// <summary>
/// GuessingNumber - Interactive number guessing game
/// User tries to guess a secret number, program counts attempts
/// Demonstrates do-while loop for user interaction and input validation
/// </summary>
class GuessingNumber
{
    /// <summary>
    /// Runs the number guessing game
    /// User keeps guessing until they find the secret number
    /// Tracks and displays the number of attempts made
    /// </summary>
    public void GuessNum()
    {
    try{
        int secret = 7;  // The secret number to guess (hardcoded for simplicity)
        int i = 1;       // Attempt counter (starts at 1)
        int num = 0;     // User's guess
        
        // Do-while loop ensures at least one iteration
        do
        {
            Console.WriteLine("Enter the number");
            string? input = Console.ReadLine();  // Get user input
            num = int.Parse(input);              // Convert to integer
            i++;  // Increment attempt counter

        }while(num != secret);  // Continue until guess matches secret
        
        // Display success message with attempt count
        Console.WriteLine($"YOU Win! your attemps was {i}");
    }catch(Exception e)
        {
            // Handle parsing errors or other exceptions
            Console.WriteLine(e.Message);
        }
    }
}