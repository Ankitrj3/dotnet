/// <summary>
/// QuadraticEquation - Calculates roots of quadratic equation ax² + bx + c = 0
/// Uses discriminant to determine the nature and values of roots
/// Discriminant = b² - 4ac
/// </summary>
class QuadraticEquation
{
    /// <summary>
    /// Calculates and displays roots of quadratic equation using discriminant analysis
    /// </summary>
    /// <param name="a">Coefficient of x²</param>
    /// <param name="b">Coefficient of x</param>
    /// <param name="c">Constant term</param>
    public void CalculateRoots(double a, double b, double c)
    {
        // Check if it's a valid quadratic equation
        if (a == 0)
        {
            Console.WriteLine("Not a quadratic equation (coefficient of x² cannot be 0)");
            return;
        }

        // Calculate discriminant: b² - 4ac
        double discriminant = (b * b) - (4 * a * c);

        // Check discriminant to determine nature of roots
        if (discriminant > 0)
        {
            // Two distinct real roots
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Two distinct real roots: {root1:F2} and {root2:F2}");
        }
        else if (discriminant == 0)
        {
            // One repeated real root
            double root = -b / (2 * a);
            Console.WriteLine($"One repeated real root: {root:F2}");
        }
        else
        {
            // Complex roots
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine($"Complex roots: {realPart:F2} + {imaginaryPart:F2}i and {realPart:F2} - {imaginaryPart:F2}i");
        }
    }
}