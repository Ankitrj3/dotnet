using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

/// <summary>
/// Prime - Determines if a number is prime
/// A prime number is a natural number greater than 1 that has no positive divisors other than 1 and itself
/// Uses optimized algorithm checking divisors only up to square root of the number
/// </summary>
public class Prime
{
    /// <summary>
    /// Checks if the given number is prime using optimized algorithm
    /// Only checks divisors up to square root for efficiency
    /// </summary>
    /// <param name="checkNum">Number to check for primality</param>
    /// <returns>String indicating if the number is prime or not</returns>
    // Prime Number: Check if a number is prime using a for loop and break.
    public string CheckPrime(int checkNum)
    {
        try{
            // Handle edge case: negative numbers are not prime
            if(checkNum < 0)
            {
                return "Not Prime";
            }
            
            // Optimization: only check divisors up to square root
            // If a number has a divisor greater than its square root,
            // it must also have a corresponding divisor less than the square root
            int limit = (int)Math.Sqrt(checkNum);
            
            // Check for divisors from 2 to square root
            for(int i = 2; i <= limit; i++)
            {
                if(checkNum % i == 0)  // If divisible, not prime
                {
                    return "Not prime";
                }
            }
            return "prime";  // No divisors found, number is prime
        }catch(Exception e)
        {
            // Return error message if exception occurs
            return e.Message;
        }
    }
}
