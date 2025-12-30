using System;
using System.Diagnostics;
/// <summary>
/// HelloDotNet - A simple C# console application demonstrating basic input/output operations
/// This program checks if a person is an adult or minor based on their age
/// </summary>
class Program
{
    /// <summary>
    /// Main entry point of the application
    /// Demonstrates age validation and adult/minor classification
    /// </summary>
    public static void Main(string [] args)
    {
        // Commented out code below shows a prime number checker implementation
        // This demonstrates basic prime number algorithm using square root optimization
        
        // Console.WriteLine("Enter your name");
        // string? name = Console.ReadLine();

        // Console.WriteLine("Hello "+name+" !");
        // Console.WriteLine("Enter a number:");
        // int num = int.Parse(Console.ReadLine()!);
        // bool isPrime = true;

        // if(num <= 1)
        // {
        //     isPrime = false;
        // }
        // else
        // {
        //     int limit = (int)Math.Sqrt(num);
        //     for(int i=2; i<=limit; i++)
        //     {
        //         if(num % i == 0)
        //         {
        //             isPrime = false;
        //             break;
        //         }
        //     }
        // }

        // if (isPrime)
        // {
        //     Console.WriteLine("Prime");
        // }
        // else
        // {
        //     Console.WriteLine("Not Prime");
        // }

        // Age validation and adult/minor classification
        // Console.WriteLine("Enter the age");
        // string? input = Console.ReadLine(); // Read user input as string (nullable)

        // // Use TryParse for safe integer conversion to avoid exceptions
        // if(int.TryParse(input, out int age))
        // {
        //     // Check if age is 18 or above to determine adult status
        //     bool isAdult = age >= 18;
        //     // Use ternary operator for concise conditional output
        //     Console.WriteLine(isAdult ? "Adult" : "Minor");
        // }
        // else
        // {
        //     // Handle invalid input gracefully
        //     Console.WriteLine("Invalid input");
        // }

        ConstructorTypes.ConstructorTypes c1 = new ConstructorTypes.ConstructorTypes();
        ConstructorTypes.ConstructorTypes c2 = new ConstructorTypes.ConstructorTypes(12,23);
        ConstructorTypes.ConstructorTypes c3 = new ConstructorTypes.ConstructorTypes(c2);
    }
}