/// <summary>
/// SumOfDigit - Calculates the digital root of a number
/// Digital root is obtained by repeatedly summing digits until a single digit remains
/// Example: 2345789 → 2+3+4+5+7+8+9 = 38 → 3+8 = 11 → 1+1 = 2
/// Uses recursion to handle the repeated summing process
/// </summary>
class SumOfDigit
{
    /// <summary>
    /// Calculates the digital root using recursive digit summing
    /// Continues summing digits until result is a single digit (0-9)
    /// </summary>
    /// <param name="number">Number to calculate digital root for</param>
    // Sum of Digits: Repeatedly sum digits of a number until the result is a single digit (Digital Root).
    public void SingleDigit(int number)
    {
    try{
        int sum = 0;  // Accumulator for digit sum
        
        // Extract and sum all digits
        while(number > 0)
        {
            int digit = number % 10;  // Extract rightmost digit
            sum += digit;             // Add digit to sum
            number /= 10;             // Remove rightmost digit
        }
        
        // If sum has more than one digit, recursively sum again
        if(sum > 9)
        {
            SingleDigit(sum);  // Recursive call with the sum
        }
        else
        {
            Console.WriteLine(sum);  // Display final single digit result
        }
        }catch(Exception e)
    {
        // Handle any exceptions during calculation
        Console.WriteLine(e.Message);
    }
    }
}
