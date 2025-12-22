/// <summary>
/// ElectricityBill - Calculates electricity bill based on unit consumption
/// Rate structure: First 199 units @ 1.20; 200-400 @ 1.50; 400-600 @ 1.80; above 600 @ 2.00
/// Adds 15% surcharge if bill > 400
/// </summary>
class ElectricityBill
{
    /// <summary>
    /// Calculates electricity bill based on units consumed with tiered pricing
    /// </summary>
    /// <param name="units">Number of units consumed</param>
    public void CalculateBill(int units)
    {
        double bill = 0;

        // Calculate bill based on tiered pricing structure
        if (units <= 199)
        {
            // First tier: up to 199 units @ 1.20 per unit
            bill = units * 1.20;
        }
        else if (units <= 400)
        {
            // Second tier: 200-400 units
            bill = (199 * 1.20) + ((units - 199) * 1.50);
        }
        else if (units <= 600)
        {
            // Third tier: 400-600 units
            bill = (199 * 1.20) + (201 * 1.50) + ((units - 400) * 1.80);
        }
        else
        {
            // Fourth tier: above 600 units
            bill = (199 * 1.20) + (201 * 1.50) + (200 * 1.80) + ((units - 600) * 2.00);
        }

        // Add 15% surcharge if bill exceeds 400
        if (bill > 400)
        {
            double surcharge = bill * 0.15;
            bill += surcharge;
            Console.WriteLine($"Units consumed: {units}");
            Console.WriteLine($"Base bill: {(bill - surcharge):F2}");
            Console.WriteLine($"Surcharge (15%): {surcharge:F2}");
            Console.WriteLine($"Total bill: {bill:F2}");
        }
        else
        {
            Console.WriteLine($"Units consumed: {units}");
            Console.WriteLine($"Total bill: {bill:F2}");
        }
    }
}