/// <summary>
/// StrongNumber - Checks if a number is a Strong number
/// A Strong number is a number whose sum of factorial of digits equals the number itself
/// Example: 145 = 1! + 4! + 5! = 1 + 24 + 120 = 145
/// Other examples: 1, 2, 145, 40585
/// </summary>
// Strong Number: Check if the sum of the factorial of digits is equal to the number itself.
using System;

class StrongNumber
{
    /// <summary>
    /// Calculates factorial of a single digit (0-9)
    /// Helper method for strong number calculation
    /// </summary>
    /// <param name="n">Digit to calculate factorial for (0-9)</param>
    /// <returns>Factorial of the digit</returns>
    public int Factorial(int n)
    {
        int fact = 1;  // Initialize factorial result
        
        // Calculate factorial by multiplying all numbers from 1 to n
        for (int i = 1; i <= n; i++)
            fact *= i;
            
        return fact;
    }

    /// <summary>
    /// Checks if a user-entered number is a Strong number
    /// Extracts each digit, calculates its factorial, and sums them
    /// Compares the sum with the original number
    /// </summary>
    public void StrongNumberCalc()
    {
        // Get input from user
        Console.Write("Enter a number: ");
        string? n = Console.ReadLine();
        int num = int.Parse(n);

        int temp = num;  // Store original number for comparison
        int sum = 0;     // Accumulator for sum of factorials

        // Extract each digit and add its factorial to sum
        while (temp > 0)
        {
            int digit = temp % 10;      // Extract rightmost digit
            sum += Factorial(digit);    // Add factorial of digit to sum
            temp /= 10;                 // Remove rightmost digit
        }

        // Compare sum of factorials with original number
        if (sum == num)
            Console.WriteLine("Strong Number");
        else
            Console.WriteLine("Not a Strong Number");
    }
}
