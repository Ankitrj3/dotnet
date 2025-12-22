/// <summary>
/// DiamondShape - Creates a diamond pattern using asterisks
/// This class demonstrates nested loops to create geometric patterns
/// The diamond consists of an upper half (expanding) and lower half (contracting)
/// </summary>
class DiamondShape
{
    /// <summary>
    /// Draws a diamond pattern with specified height
    /// Uses nested loops: outer loop for rows, inner loops for spaces and stars
    /// </summary>
    /// <param name="n">Height of the diamond (number of rows in upper half)</param>
    public void DrawDiamond(int n)
    {
        // Upper half of diamond (expanding pattern)
        for(int i = 1; i <= n; i++)
        {
            // Print leading spaces to center the stars
            // Number of spaces decreases as we go down: (n-i) spaces
            for(int spaces = 1; spaces <= n - i; spaces++)
            {
                Console.Write(" ");
            }
            
            // Print stars for current row
            // Number of stars follows pattern: 2*i - 1 (1, 3, 5, 7, ...)
            for(int star = 1; star <= 2*i - 1; star++)
            {
                Console.Write("*");
            }

            Console.WriteLine(""); // Move to next line
        }

        // Lower half of diamond (contracting pattern)
        for(int i=n-1; i>=1; i--) // Start from n-1 and go down to 1
        {
            // Print leading spaces (same logic as upper half)
            for(int spaces=1; spaces<=n-i; spaces++)
            {
                Console.Write(" ");
            }
            
            // Print stars (same pattern as upper half)
            for(int star=1; star<=2*i-1; star++)
            {
                Console.Write("*");
            }

            Console.WriteLine(""); // Move to next line
        }
    }
}