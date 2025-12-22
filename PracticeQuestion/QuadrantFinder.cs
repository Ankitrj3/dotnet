/// <summary>
/// QuadrantFinder - Determines which quadrant a point lies in based on coordinates
/// Quadrant I: (+x, +y), Quadrant II: (-x, +y), Quadrant III: (-x, -y), Quadrant IV: (+x, -y)
/// Also handles points on axes
/// </summary>
class QuadrantFinder
{
    /// <summary>
    /// Determines the quadrant of a point based on its (x, y) coordinates
    /// </summary>
    /// <param name="x">X-coordinate</param>
    /// <param name="y">Y-coordinate</param>
    public void FindQuadrant(double x, double y)
    {
        // Check for origin
        if (x == 0 && y == 0)
        {
            Console.WriteLine("Point is at the Origin");
        }
        // Check for points on axes
        else if (x == 0)
        {
            Console.WriteLine("Point lies on the Y-axis");
        }
        else if (y == 0)
        {
            Console.WriteLine("Point lies on the X-axis");
        }
        // Determine quadrant based on sign of coordinates
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Point lies in Quadrant I");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Point lies in Quadrant II");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Point lies in Quadrant III");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Point lies in Quadrant IV");
        }
    }
}