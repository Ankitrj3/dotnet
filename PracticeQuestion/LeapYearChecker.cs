/// <summary>
/// LeapYearChecker - Determines if a given year is a leap year
/// Leap year rules: Divisible by 400 OR (Divisible by 4 and NOT divisible by 100)
/// </summary>
class LeapYearChecker
{
    /// <summary>
    /// Determines if a given year is a leap year
    /// Leap year rules: Divisible by 400 OR (Divisible by 4 and NOT divisible by 100)
    /// </summary>
    /// <param name="year">Year to check</param>
    /// <returns>String indicating if it's a leap year or not</returns>
    public string CheckLeapYear(int year)
    {
        // Apply leap year logic
        if (year % 4 == 0 || (year % 400 == 0 && year % 100 != 0))
        {
            return "Leap year";
        }
        else
        {
            return "Not a Leap year";
        }
    }
}