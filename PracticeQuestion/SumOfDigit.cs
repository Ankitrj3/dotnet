class SumOfDigit
{
    // Sum of Digits: Repeatedly sum digits of a number until the result is a single digit (Digital Root).
    public void SingleDigit(int number)
    {
    try{
        int sum = 0;
        
            while(number > 0)
            {
                int digit = number % 10;
                sum += digit;
                number /= 10;
            }
            if(sum > 9)
            {
                SingleDigit(sum);
            }
            else
            {
                Console.WriteLine(sum);
            }
        }catch(Exception e)
    {
        Console.WriteLine(e.Message);
    }
    }
}
