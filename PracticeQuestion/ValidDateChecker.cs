/// <summary>
/// ValidDateChecker - Validates if a given date is valid in the calendar
/// Handles leap years, different month lengths, and February 29th validation
/// </summary>
class ValidDateChecker
{
    /// <summary>
    /// Checks if the given date is valid, considering leap years and month lengths
    /// </summary>
    /// <param name="day">Day of the month</param>
    /// <param name="month">Month (1-12)</param>
    /// <param name="year">Year</param>
    public void CheckValidDate(int day, int month, int year)
    {
        // Check basic range validity
        if (month < 1 || month > 12)
        {
            Console.WriteLine("Invalid date: Month must be between 1 and 12");
            return;
        }

        if (day < 1)
        {
            Console.WriteLine("Invalid date: Day must be positive");
            return;
        }

        // Days in each month (non-leap year)
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        // Check for leap year and adjust February days
        if (IsLeapYear(year))
        {
            daysInMonth[1] = 29; // February has 29 days in leap year
        }

        // Check if day is valid for the given month
        if (day > daysInMonth[month - 1])
        {
            Console.WriteLine($"Invalid date: {GetMonthName(month)} has only {daysInMonth[month - 1]} days in {year}");
        }
        else
        {
            Console.WriteLine($"Valid date: {day}/{month}/{year}");
        }
    }

    /// <summary>
    /// Determines if a year is a leap year
    /// </summary>
    /// <param name="year">Year to check</param>
    /// <returns>True if leap year, false otherwise</returns>
    private bool IsLeapYear(int year)
    {
        // Leap year rules: divisible by 400 OR (divisible by 4 AND not divisible by 100)
        return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
    }

    /// <summary>
    /// Gets month name for better error messages
    /// </summary>
    /// <param name="month">Month number (1-12)</param>
    /// <returns>Month name</returns>
    private string GetMonthName(int month)
    {
        string[] monthNames = { "January", "February", "March", "April", "May", "June",
                               "July", "August", "September", "October", "November", "December" };
        return monthNames[month - 1];
    }
}