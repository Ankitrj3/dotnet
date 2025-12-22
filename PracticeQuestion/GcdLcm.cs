// GCD and LCM: Find the Greatest Common Divisor and Least Common Multiple of two numbers.
using System.Linq.Expressions;

public class GcdLcm{
    public void gcdlcm(int num1, int num2)
    {
      try{
        int a = num1;
        int b = num2;
        while(num2 != 0)
        {
            int rem = num1 % num2;
            num1 = num2;
            num2 = rem;
        }
        Console.WriteLine("This the GCD of your Entered Value "+num1);
        Console.WriteLine("This is the LCM of your Entered Value "+(a*b)/num1);
    }catch(Exception e){
        Console.WriteLine(e.Message);
    }
    }
}