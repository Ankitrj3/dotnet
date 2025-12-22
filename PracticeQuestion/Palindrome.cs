class Palindrome
{
    public void PalindromeCheck(int num)
    {
        int rev = 0;
        int originalNum = num;
        while(num > 0)
        {
            int digit = num % 10;
            rev = (rev * 10) + digit;
            num = num/10;
        }
        if(rev == originalNum)
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }
}