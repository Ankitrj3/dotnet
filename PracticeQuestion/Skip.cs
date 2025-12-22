/// <summary>
/// Skip - Demonstrates the 'continue' statement in loops
/// Prints numbers from 1 to n but skips all multiples of 3
/// Shows how 'continue' can be used to skip specific iterations in a loop
/// </summary>
class Skip
{
    /// <summary>
    /// Prints numbers from 1 to n, skipping multiples of 3
    /// Uses 'continue' statement to skip loop iterations
    /// </summary>
    /// <param name="n">Upper limit for number printing</param>
    // Continue Usage: Print numbers from 1 to 50, but skip all multiples of 3 using continue
    public void Skip3Multiple(int n)
    {
        // Loop through numbers from 1 to n
        for(int i = 1; i <= n; i++)
        {
            // Check if current number is divisible by 3
            if (i % 3 == 0)
            {
                continue;  // Skip this iteration, don't print the number
            }
            Console.WriteLine(i);  // Print the number (only non-multiples of 3)
        }
    }
}