/// <summary>
/// GcdLcm - Calculates Greatest Common Divisor (GCD) and Least Common Multiple (LCM)
/// Uses Euclidean algorithm for GCD calculation
/// LCM is calculated using the relationship: LCM(a,b) = (a × b) / GCD(a,b)
/// </summary>
// GCD and LCM: Find the Greatest Common Divisor and Least Common Multiple of two numbers.
using System.Linq.Expressions;

public class GcdLcm{
    /// <summary>
    /// Calculates and displays both GCD and LCM of two numbers
    /// Uses Euclidean algorithm for efficient GCD calculation
    /// </summary>
    /// <param name="num1">First number</param>
    /// <param name="num2">Second number</param>
    public void gcdlcm(int num1, int num2)
    {
      try{
        // Store original values for LCM calculation
        int a = num1;
        int b = num2;
        
        // Euclidean algorithm for GCD
        // Repeatedly divide and take remainder until remainder becomes 0
        while(num2 != 0)
        {
            int rem = num1 % num2;  // Calculate remainder
            num1 = num2;            // Dividend becomes divisor
            num2 = rem;             // Divisor becomes remainder
        }
        // When num2 becomes 0, num1 contains the GCD
        
        Console.WriteLine("This the GCD of your Entered Value "+num1);
        
        // Calculate LCM using formula: LCM(a,b) = (a × b) / GCD(a,b)
        Console.WriteLine("This is the LCM of your Entered Value "+(a*b)/num1);
    }catch(Exception e){
        // Handle any exceptions during calculation
        Console.WriteLine(e.Message);
    }
    }
}