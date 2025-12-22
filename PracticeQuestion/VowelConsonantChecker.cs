/// <summary>
/// VowelConsonantChecker - Determines if a character is a vowel or consonant
/// Uses switch statement to check for vowels (both uppercase and lowercase)
/// </summary>
class VowelConsonantChecker
{
    /// <summary>
    /// Determines if a character is a vowel or consonant using switch statement
    /// </summary>
    /// <param name="checkValue">Character to check</param>
    public void VowelOrConsonant(char checkValue)
    {
        // Switch statement to check for vowels (both uppercase and lowercase)
        switch (checkValue)
        {
            case 'a':
            case 'A':
                Console.WriteLine("Vowel");
                break;
            case 'e':
            case 'E':
                Console.WriteLine("Vowel");
                break;
            case 'i':
            case 'I':
                Console.WriteLine("Vowel");
                break;
            case 'o':
            case 'O':
                Console.WriteLine("Vowel");
                break;
            case 'u':
            case 'U':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant"); // All non-vowels are consonants
                break;
        }
    }
}