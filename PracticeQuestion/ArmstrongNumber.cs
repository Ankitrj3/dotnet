/// <summary>
/// ArmstrongNumber - Checks if a number is an Armstrong number
/// An Armstrong number is a number that equals the sum of its digits raised to the power of the number of digits
/// Example: 153 = 1³ + 5³ + 3³ = 1 + 125 + 27 = 153
/// Note: This implementation assumes 3-digit numbers (cubes), but can be extended for any number of digits
/// </summary>
class ArmstrongNumber
{
    /// <summary>
    /// Checks if the given number is an Armstrong number
    /// Uses digit extraction and cube calculation to verify the Armstrong property
    /// </summary>
    /// <param name="num">Number to check for Armstrong property</param>
    // Armstrong Number: Check if a number equals the sum of its digits raised to the power of number of digits.
    public void ArmStrongNum(int num)
    {
      try{
        int originalNum = num;  // Store original number for comparison
        int sum = 0;            // Accumulator for sum of cubes
        
        // Extract each digit and calculate sum of cubes
        while(num > 0)
        {
            int digit = num%10;         // Extract rightmost digit
            sum += digit * digit * digit; // Add cube of digit to sum
            num = num/10;               // Remove rightmost digit
        }
        
        // Compare calculated sum with original number
        if(sum == originalNum)
        {
            Console.WriteLine("Its Armstrong number");
        }
        else
        {
            Console.WriteLine("Its not Armstrong number");
        }
    }catch(Exception e){
        // Handle any exceptions that might occur during calculation
        Console.WriteLine(e.Message);
    }
    }
}