/// <summary>
/// HeightCategory - Categorizes people based on their height in centimeters
/// Provides classification into Dwarf, Average, Tall, or Abnormal categories
/// </summary>
class HeightCategory
{
    /// <summary>
    /// Categorizes a person's height into predefined categories
    /// </summary>
    /// <param name="height">Height in centimeters</param>
    public void CheckHeight(int height)
    {
        // Use if-else chain to categorize height
        if (height < 150)
        {
            Console.WriteLine("Dwarf");
        }
        else if (height >= 150 && height < 165)
        {
            Console.WriteLine("Average");
        }
        else if (height >= 165 && height < 190)
        {
            Console.WriteLine("Tall");
        }
        else if (height >= 190)
        {
            Console.WriteLine("Abnormal");
        }
    }
}