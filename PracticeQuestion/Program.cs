/// <summary>
/// Practice Questions Program - Collection of programming exercises and algorithms
/// This program demonstrates various programming concepts including:
/// - Conditional statements (if-else, switch)
/// - Loops and iterations
/// - Method calls and object instantiation
/// - Mathematical calculations and validations
/// </summary>
class Program
{
    /// <summary>
    /// Main entry point - Demonstrates all the implemented algorithms and methods
    /// Creates instances of various classes and calls their methods to show functionality
    /// </summary>
    /// <param name="args">Command line arguments</param>
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Practice Questions Demonstration ===\n");

        // Height Category Test: Accept height in cm. If < 150 (Dwarf), 150-165 (Average), 165-190 (Tall), >190 (Abnormal).
        Console.WriteLine("1. Height Category Test:");
        HeightCategory heightChecker = new HeightCategory();
        heightChecker.CheckHeight(165);
        Console.WriteLine();

        // Largest of Three Test: Take three integers and find the maximum using nested if
        Console.WriteLine("2. Maximum of Three Numbers Test:");
        MaximumFinder maxFinder = new MaximumFinder();
        int maxNum = maxFinder.MaxNum(12, 34, 14);
        Console.WriteLine($"Maximum of 12, 34, 14 is: {maxNum}");
        Console.WriteLine();

        // Leap Year Test: Determine if a year is leap (Divisible by 400 OR (Divisible by 4 and NOT 100)).
        Console.WriteLine("3. Leap Year Test:");
        LeapYearChecker leapChecker = new LeapYearChecker();
        string checkLeapYear = leapChecker.CheckLeapYear(2024);
        Console.WriteLine($"2024 is: {checkLeapYear}");
        Console.WriteLine();

        // Quadratic Equation Test: Calculate roots of ax² + bx + c = 0
        Console.WriteLine("4. Quadratic Equation Test:");
        QuadraticEquation quadratic = new QuadraticEquation();
        quadratic.CalculateRoots(1, -5, 6); // x² - 5x + 6 = 0
        Console.WriteLine();

        // Admission Eligibility Test: Math ≥ 65, Phys ≥ 55, Chem ≥ 50 AND (Total ≥ 180 OR Math+Phys ≥ 140).
        Console.WriteLine("5. Admission Eligibility Test:");
        AdmissionEligibility admissionChecker = new AdmissionEligibility();
        string admission = admissionChecker.CheckAdmissionEligibility(70, 60, 55);
        Console.WriteLine($"Admission status: {admission}");
        Console.WriteLine();

        // Electricity Bill Test: Calculate bill with tiered pricing
        Console.WriteLine("6. Electricity Bill Test:");
        ElectricityBill billCalculator = new ElectricityBill();
        billCalculator.CalculateBill(450);
        Console.WriteLine();

        // Vowel or Consonant Test: Use a switch statement to check if a character is a vowel.
        Console.WriteLine("7. Vowel/Consonant Test:");
        VowelConsonantChecker vowelChecker = new VowelConsonantChecker();
        vowelChecker.VowelOrConsonant('a');
        Console.WriteLine();

        // Triangle Type Test: Check if triangle is Equilateral, Isosceles, or Scalene
        Console.WriteLine("8. Triangle Type Test:");
        TriangleType triangleChecker = new TriangleType();
        triangleChecker.CheckTriangleType(5, 5, 8);
        Console.WriteLine();

        // Quadrant Finder Test: Determine quadrant of a point
        Console.WriteLine("9. Quadrant Finder Test:");
        QuadrantFinder quadrantFinder = new QuadrantFinder();
        quadrantFinder.FindQuadrant(3, -4);
        Console.WriteLine();

        // Grade Description Test: Input grade (E, V, G, A, F) and print description
        Console.WriteLine("10. Grade Description Test:");
        GradeConverter gradeConverter = new GradeConverter();
        string gradeCheck = gradeConverter.GradeDescription('A');
        Console.WriteLine($"Grade A means: {gradeCheck}");
        Console.WriteLine();

        // Valid Date Check Test: Check if date is valid
        Console.WriteLine("11. Valid Date Check Test:");
        ValidDateChecker dateChecker = new ValidDateChecker();
        dateChecker.CheckValidDate(29, 2, 2024); // Leap year February 29
        Console.WriteLine();

        // ATM Withdrawal Test: Nested if validation
        Console.WriteLine("12. ATM Withdrawal Test:");
        ATMWithdrawal atmSystem = new ATMWithdrawal();
        atmSystem.ProcessWithdrawal(true, 1234, 1234, 1000.0, 200.0);
        Console.WriteLine();

        // Profit/Loss Test: Calculate profit or loss percentage
        Console.WriteLine("13. Profit/Loss Calculator Test:");
        ProfitLossCalculator profitLoss = new ProfitLossCalculator();
        profitLoss.CalculateProfitLoss(100, 120);
        Console.WriteLine();

        // Rock Paper Scissors Test: 2-player game logic
        Console.WriteLine("14. Rock Paper Scissors Test:");
        RockPaperScissors game = new RockPaperScissors();
        game.PlayGame('R', 'S');
        Console.WriteLine();

        // Simple Calculator Test: Basic arithmetic operations
        Console.WriteLine("15. Simple Calculator Test:");
        SimpleCalculator calculator = new SimpleCalculator();
        calculator.Calculate(15, 3, '/');
        Console.WriteLine();

        // Prime Number Test: Check if a number is prime using a for loop and break.
        Console.WriteLine("16. Prime Number Test:");
        Prime prime = new Prime();
        string checkPrime = prime.CheckPrime(13);
        Console.WriteLine($"13 is: {checkPrime}");
        Console.WriteLine();

        // Fibonacci Series Test: Display the first N terms of the Fibonacci sequence.
        Console.WriteLine("17. Fibonacci Series Test:");
        FibonacciSeries fb = new FibonacciSeries();
        fb.Fibseries(10);
        Console.WriteLine();

        // Armstrong Number Test: Check if a number equals the sum of its digits raised to the power of number of digits.
        Console.WriteLine("18. Armstrong Number Test:");
        ArmstrongNumber an = new ArmstrongNumber();
        an.ArmStrongNum(153);
        Console.WriteLine();

        // Reverse & Palindrome Test: Reverse an integer and check if it is a palindrome using while.
        Console.WriteLine("19. Palindrome Test:");
        Palindrome pd = new Palindrome();
        pd.PalindromeCheck(121);
        Console.WriteLine();

        // Continue Usage Test: Print numbers from 1 to 50, but skip all multiples of 3 using continue
        Console.WriteLine("20. Skip Multiples of 3 Test:");
        Skip sk = new Skip();
        sk.Skip3Multiple(15); // Using smaller number for demo
        Console.WriteLine();

        // Factorial Test (Large numbers): Calculate N! and handle potential overflow for larger integers.
        Console.WriteLine("21. Factorial Test:");
        Factorial fc = new Factorial();
        fc.Fact(5);
        Console.WriteLine();

        // Diamond Pattern Test: Print a diamond shape using * characters with nested loops.
        Console.WriteLine("22. Diamond Pattern Test:");
        DiamondShape dp = new DiamondShape();
        dp.DrawDiamond(3); // Using smaller size for demo
        Console.WriteLine();

        // Sum of Digits Test: Repeatedly sum digits until single digit (Digital Root)
        Console.WriteLine("23. Sum of Digits (Digital Root) Test:");
        SumOfDigit s = new SumOfDigit();
        s.SingleDigit(2345789);
        Console.WriteLine();

        // GCD and LCM Test: Find the Greatest Common Divisor and Least Common Multiple of two numbers.
        Console.WriteLine("24. GCD and LCM Test:");
        GcdLcm gl = new GcdLcm();
        gl.gcdlcm(12, 18);
        Console.WriteLine();

        // Binary to Decimal Test: Convert a binary number string to decimal without using built-in library functions.
        Console.WriteLine("25. Binary to Decimal Test:");
        Practice.BinaryToDecimal bd = new Practice.BinaryToDecimal();
        int res = bd.Conversion("1011");
        Console.WriteLine($"Binary 1011 = Decimal {res}");
        Console.WriteLine();

        // Strong Number Test: Check if the sum of the factorial of digits is equal to the number itself.
        Console.WriteLine("26. Strong Number Test:");
        StrongNumber sn = new StrongNumber();
        sn.StrongNumberCalc();

       
    }
}