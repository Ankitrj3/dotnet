using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Prime
{
    // Prime Number: Check if a number is prime using a for loop and break.
    public string CheckPrime(int checkNum)
    {
        try{
            if(checkNum < 0)
            {
                return "Not Prime";
            }
            int limit = (int)Math.Sqrt(checkNum);
            for(int i = 2; i <= limit; i++)
            {
                if(checkNum % i == 0)
                {
                    return "Not prime";
                }
            }
            return "prime";
        }catch(Exception e)
        {
            return e.Message;
        }
    }
}
