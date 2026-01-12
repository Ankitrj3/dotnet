using System.Runtime.CompilerServices;

namespace DiscountSystem
{
    public delegate double Discount(double amount);
    public class CalculateDiscount
    {
        public Discount? discount;
        public void Calculate(double amount, Discount discount)
        {
            Console.WriteLine($"This the Discounted Price {discount(amount)}");
        }
    }
    public class Program
    {
        public static void Main()
        {
            CalculateDiscount cs = new CalculateDiscount();
            Discount ds = TwentyPercent;
            cs.Calculate(12000, ds);
        }
        private static double TenPercent(double amount)
        {
            return amount * 0.10;
        }
        private static double TwentyPercent(double amount)
        {
            return amount * 0.20;
        }
    }
}