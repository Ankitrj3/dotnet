/// <summary>
/// FibonacciSeries - Generates and displays Fibonacci sequence
/// Fibonacci sequence: Each number is the sum of the two preceding ones
/// Sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, ...
/// Formula: F(n) = F(n-1) + F(n-2), where F(0) = 0, F(1) = 1
/// </summary>
public class FibonacciSeries
{
    /// <summary>
    /// Generates and displays Fibonacci numbers up to the specified limit
    /// Uses iterative approach with three variables to track sequence
    /// </summary>
    /// <param name="num">Upper limit for Fibonacci sequence generation</param>
    // Fibonacci Series: Display the first N terms of the Fibonacci sequence.
    public void Fibseries(int num)
    {
      try{
        int a = 0;    // First Fibonacci number
        int b = 1;    // Second Fibonacci number
        int sum = 0;  // Current Fibonacci number (sum of previous two)

        // Handle special cases for first two Fibonacci numbers
        if(num == 0)
        {
            Console.WriteLine(0);  // Only F(0)
        }else if(num == 1)
        {
            Console.WriteLine(1);  // Only F(1)
        }
        else
        {
            // Generate Fibonacci sequence until sum exceeds the limit
            while(sum <= num)
            {
                Console.WriteLine(sum+"\n");  // Display current Fibonacci number
                sum = a+b;  // Calculate next Fibonacci number
                a = b;      // Move to next pair: a becomes previous b
                b = sum;    // b becomes current sum
            }
        }
      }catch(Exception e)
        {
            // Handle any exceptions during calculation
            Console.WriteLine(e.Message);
        }
    }
}