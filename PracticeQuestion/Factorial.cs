// Factorial (Large numbers): Calculate N! and handle potential overflow for larger integers.

using System.Numerics;

class Factorial
{
    public void Fact(int num)
    {
        BigInteger fact = 1;
        for(int i = 1; i<=num; i++)
        {
            fact *= i;
        }
        Console.WriteLine(fact);
    }
}