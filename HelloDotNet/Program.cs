using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
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

        Console.WriteLine("Enter the age");
        string? input = Console.ReadLine();

        if(int.TryParse(input, out int age))
        {
            bool isAdult = age >= 18;
            Console.WriteLine(isAdult ? "Adult" : "Minor");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}