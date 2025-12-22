class ArmstrongNumber
{
    // Armstrong Number: Check if a number equals the sum of its digits raised to the power of number of digits.
    public void ArmStrongNum(int num)
    {
      try{
        int originalNum = num;
        int sum = 0;
        while(num > 0)
        {
            int digit = num%10;
            sum += digit * digit * digit;
            num = num/10;
        }
        if(sum == originalNum)
        {
            Console.WriteLine("Its Armstrong number");
        }
        else
        {
            Console.WriteLine("Its not Armstrong number");
        }
    }catch(Exception e){
        Console.WriteLine(e.Message);
    }
    }
}