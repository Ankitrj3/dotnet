using System.Collections;
using System.Runtime.InteropServices;

class Program
{
    // Height Category: Accept height in cm. If < 150 (Dwarf), 150-165 (Average), 165-190 (Tall), >190 (Abnormal).
    public void CheckHeight(int height)
    {
        if(height < 150)
        {
            Console.WriteLine("Dwarf");
        }else if(height >= 150 && height < 165)
        {
            Console.WriteLine("Average");
        }else if(height >=165 && height < 190)
        {
            Console.WriteLine("Tail");
        }else if(height >= 190)
        {
            Console.WriteLine("Abnormal");
        }
    }

    //Largest of Three: Take three integers and find the maximum using nested if
    public int MaxNum(int num1,int num2,int num3)
    {
        if(num1 > num2 && num1 > num3)
        {
            return num1;
        }else if(num2 > num1 && num2 > num3)
        {
            return num2;
        }
        else
        {
            return num3;
        }
    }
    // Leap Year Checker: Determine if a year is leap (Divisible by 400 OR (Divisible by 4 and NOT 100)).
    public string CheckLeapYear(int year)
    {
        if(year % 4 == 0 || (year % 400 == 0 && year % 100 !=0))
        {
            return "Leap year";
        }
        else
        {
            return "Not a Leap year";
        }
    }

    //Vowel or Consonant: Use a switch statement to check if a character is a vowel.
    public void VowelOrConsonant(char checkValue)
    {
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
                Console.WriteLine("Consonant");
                break;
        }
    }

    // Grade Description: Input grade (E, V, G, A, F) and print (Excellent, Very Good, Good, Average, Fail) using switch
    public string GradeDescription(char grade)
    {
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

    // Admission Eligibility: Math ≥ 65, Phys ≥ 55, Chem ≥ 50 AND (Total ≥ 180 OR Math+Phys ≥ 140).
    public string AdmissionEligibility(double math, double phys, double chem)
    {
        double total = math+phys+chem;
        double mathphys = math+phys;

        if(math >= 65 && phys >=55 && chem >= 50 && (total >=180 || mathphys >= 140))
        {
            return "eligible";
        }
        else
        {
            return "not eligible";
        }
    }
    public static void Main(string [] args)
    {
        // Height Category: Accept height in cm. If < 150 (Dwarf), 150-165 (Average), 165-190 (Tall), >190 (Abnormal).
       Program pro = new Program();
       pro.CheckHeight(165);

       //Largest of Three: Take three integers and find the maximum using nested if
       int maxNum = pro.MaxNum(12,34,14);
       Console.WriteLine(maxNum);

       // Leap Year Checker: Determine if a year is leap (Divisible by 400 OR (Divisible by 4 and NOT 100)).
       string checkLeapYear = pro.CheckLeapYear(2024);
       Console.WriteLine(checkLeapYear);

       //Vowel or Consonant: Use a switch statement to check if a character is a vowel.
       pro.VowelOrConsonant('f');

        // Grade Description: Input grade (E, V, G, A, F) and print (Excellent, Very Good, Good, Average, Fail) using switch
        string gradeCheck = pro.GradeDescription('a');
        Console.WriteLine(gradeCheck);

        // Prime Number: Check if a number is prime using a for loop and break.
        Prime prime = new Prime();
        string checkPrime = prime.CheckPrime(13);
        Console.WriteLine(checkPrime);

        // Admission Eligibility: Math ≥ 65, Phys ≥ 55, Chem ≥ 50 AND (Total ≥ 180 OR Math+Phys ≥ 140).
        string Admission = pro.AdmissionEligibility(60,60,51);
        Console.WriteLine(Admission);

        // Fibonacci Series: Display the first N terms of the Fibonacci sequence.
        FibonacciSeries fb = new FibonacciSeries();
        fb.Fibseries(10);

        // Armstrong Number: Check if a number equals the sum of its digits raised to the power of number of digits.
        ArmstrongNumber an = new ArmstrongNumber();
        an.ArmStrongNum(153);

        // Reverse & Palindrome: Reverse an integer and check if it is a palindrome using while.
        Palindrome pd = new Palindrome();
        pd.PalindromeCheck(1211);

        // Continue Usage: Print numbers from 1 to 50, but skip all multiples of 3 using continue
        Skip sk = new Skip();
        sk.Skip3Multiple(50);

        // Factorial (Large numbers): Calculate N! and handle potential overflow for larger integers.
        Factorial fc = new Factorial();
        fc.Fact(4);

        // Diamond Pattern: Print a diamond shape using * characters with nested loops.
        DiamondShape dp = new DiamondShape();
        dp.DrawDiamond(5);

        // Guessing Game: Use do-while to let a user guess a secret number until they get it right.
        //  GuessingNumber gn = new GuessingNumber();
        //  gn.GuessNum();

        SumOfDigit s = new SumOfDigit();
        s.SingleDigit(2345789);

        // GCD and LCM: Find the Greatest Common Divisor and Least Common Multiple of two numbers.
        GcdLcm gl = new GcdLcm();
        gl.gcdlcm(12,18);

        // Binary to Decimal: Convert a binary number string to decimal without using built-in library functions.
        Practice.BinaryToDecimal bd = new Practice.BinaryToDecimal();
        int res = bd.Conversion("1011");
        Console.WriteLine(res);

    }
}