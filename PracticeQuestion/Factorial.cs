/// <summary>
/// Factorial - Calculates factorial of a number using BigInteger for large results
/// Factorial of n (n!) = n × (n-1) × (n-2) × ... × 2 × 1
/// Uses BigInteger to handle large factorial values that exceed int/long limits
/// </summary>
// Factorial (Large numbers): Calculate N! and handle potential overflow for larger integers.

using System.Numerics;

class Factorial
{
    /// <summary>
    /// Calculates factorial of given number
    /// Uses BigInteger to prevent overflow for large factorials
    /// </summary>
    /// <param name="num">Number to calculate factorial for</param>
    public void Fact(int num)
    {
        BigInteger fact = 1;  // Use BigInteger to handle large results
        
        // Multiply all numbers from 1 to num
        for(int i = 1; i<=num; i++)
        {
            fact *= i;  // Multiply current number with accumulated factorial
        }
        
        Console.WriteLine(fact);  // Display the factorial result
    }
}