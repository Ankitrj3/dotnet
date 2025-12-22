public class FibonacciSeries
{
    // Fibonacci Series: Display the first N terms of the Fibonacci sequence.
    public void Fibseries(int num)
    {
      try{
        int a = 0;
        int b = 1;
        int sum = 0;

        if(num == 0)
        {
            Console.WriteLine(0);
        }else if(num == 1)
        {
            Console.WriteLine(1);
        }
        else
        {
            while(sum <= num)
            {
                Console.WriteLine(sum+"\n");
                sum = a+b;
                a = b;
                b = sum;
            }
        }
      }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}