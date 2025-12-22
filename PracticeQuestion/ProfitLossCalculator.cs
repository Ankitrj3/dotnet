/// <summary>
/// ProfitLossCalculator - Calculates profit or loss percentage based on cost and selling price
/// Formula: Profit% = ((SP - CP) / CP) × 100, Loss% = ((CP - SP) / CP) × 100
/// </summary>
class ProfitLossCalculator
{
    /// <summary>
    /// Calculates and displays profit or loss percentage
    /// </summary>
    /// <param name="costPrice">Cost price of the item</param>
    /// <param name="sellingPrice">Selling price of the item</param>
    public void CalculateProfitLoss(double costPrice, double sellingPrice)
    {
        // Validate input values
        if (costPrice <= 0)
        {
            Console.WriteLine("Invalid input: Cost price must be positive");
            return;
        }

        if (sellingPrice < 0)
        {
            Console.WriteLine("Invalid input: Selling price cannot be negative");
            return;
        }

        // Calculate difference
        double difference = sellingPrice - costPrice;

        if (difference > 0)
        {
            // Profit case
            double profitPercentage = (difference / costPrice) * 100;
            Console.WriteLine($"Cost Price: ${costPrice:F2}");
            Console.WriteLine($"Selling Price: ${sellingPrice:F2}");
            Console.WriteLine($"Profit: ${difference:F2}");
            Console.WriteLine($"Profit Percentage: {profitPercentage:F2}%");
        }
        else if (difference < 0)
        {
            // Loss case
            double loss = Math.Abs(difference);
            double lossPercentage = (loss / costPrice) * 100;
            Console.WriteLine($"Cost Price: ${costPrice:F2}");
            Console.WriteLine($"Selling Price: ${sellingPrice:F2}");
            Console.WriteLine($"Loss: ${loss:F2}");
            Console.WriteLine($"Loss Percentage: {lossPercentage:F2}%");
        }
        else
        {
            // No profit, no loss
            Console.WriteLine($"Cost Price: ${costPrice:F2}");
            Console.WriteLine($"Selling Price: ${sellingPrice:F2}");
            Console.WriteLine("No Profit, No Loss (Break-even)");
        }
    }
}