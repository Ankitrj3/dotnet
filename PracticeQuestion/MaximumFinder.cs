/// <summary>
/// MaximumFinder - Finds the maximum value among three integers
/// Uses nested if statements to determine the largest number
/// </summary>
class MaximumFinder
{
    /// <summary>
    /// Finds the maximum of three integers using nested if statements
    /// </summary>
    /// <param name="num1">First number</param>
    /// <param name="num2">Second number</param>
    /// <param name="num3">Third number</param>
    /// <returns>The largest of the three numbers</returns>
    public int MaxNum(int num1, int num2, int num3)
    {
        // Compare first number with other two
        if (num1 > num2 && num1 > num3)
        {
            return num1;
        }
        else if (num2 > num1 && num2 > num3) // Compare second with remaining
        {
            return num2;
        }
        else
        {
            return num3; // Third number is largest by elimination
        }
    }
}