/// <summary>
/// TriangleType - Determines the type of triangle based on side lengths
/// Classifies triangles as Equilateral, Isosceles, or Scalene
/// Also validates if the given sides can form a valid triangle
/// </summary>
class TriangleType
{
    /// <summary>
    /// Determines triangle type based on three side lengths
    /// First validates if sides can form a triangle, then classifies the type
    /// </summary>
    /// <param name="side1">First side length</param>
    /// <param name="side2">Second side length</param>
    /// <param name="side3">Third side length</param>
    public void CheckTriangleType(double side1, double side2, double side3)
    {
        // Validate if sides can form a triangle (triangle inequality theorem)
        // Sum of any two sides must be greater than the third side
        if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
        {
            Console.WriteLine("Invalid triangle: These sides cannot form a triangle");
            return;
        }

        // Check for negative or zero values
        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid input: Side lengths must be positive");
            return;
        }

        // Classify triangle type based on side equality
        if (side1 == side2 && side2 == side3)
        {
            // All three sides are equal
            Console.WriteLine("Equilateral Triangle");
        }
        else if (side1 == side2 || side2 == side3 || side1 == side3)
        {
            // Any two sides are equal
            Console.WriteLine("Isosceles Triangle");
        }
        else
        {
            // All sides are different
            Console.WriteLine("Scalene Triangle");
        }
    }
}