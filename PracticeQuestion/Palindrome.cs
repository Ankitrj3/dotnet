/// <summary>
/// Palindrome - Checks if a number reads the same forwards and backwards
/// A palindrome number remains the same when its digits are reversed
/// Examples: 121, 1331, 12321 are palindromes; 123, 1234 are not
/// </summary>
class Palindrome
{
    /// <summary>
    /// Checks if the given number is a palindrome
    /// Reverses the number digit by digit and compares with original
    /// </summary>
    /// <param name="num">Number to check for palindrome property</param>
    public void PalindromeCheck(int num)
    {
        int rev = 0;            // Accumulator for reversed number
        int originalNum = num;  // Store original number for comparison
        
        // Reverse the number digit by digit
        while(num > 0)
        {
            int digit = num % 10;           // Extract rightmost digit
            rev = (rev * 10) + digit;       // Add digit to reversed number
            num = num/10;                   // Remove rightmost digit from original
        }
        
        // Compare reversed number with original
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