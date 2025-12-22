/// <summary>
/// GradeConverter - Converts grade letters to descriptive text
/// Uses switch statement to handle grade conversion for both uppercase and lowercase
/// </summary>
class GradeConverter
{
    /// <summary>
    /// Converts grade letters to descriptive text using switch statement
    /// </summary>
    /// <param name="grade">Grade letter (E, V, G, A, F)</param>
    /// <returns>Descriptive text for the grade</returns>
    public string GradeDescription(char grade)
    {
        // Switch statement for grade conversion (handles both cases)
        switch (grade)
        {
            case 'E':
            case 'e':
                return "Excellent";
            case 'V':
            case 'v':
                return "Very Good";
            case 'G':
            case 'g':
                return "Good";
            case 'A':
            case 'a':
                return "Average";
            case 'F':
            case 'f':
                return "Fail";
            default:
                return "Invalid Grade";
        }
    }
}