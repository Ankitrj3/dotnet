// Question 6: Method Overloading – Billing System
// Design a billing module that calculates total price with different combinations of tax and discount.

public class BillingSystem
{
    public BillingSystem()
    {
        Console.WriteLine("........Billing System.........");
    }
    public double CalculateTotal(double price)
    {
        return price;
    }
    public double CalculateTotal(double price, double tax)
    {
        return price+tax;
    }
    public double CalculateTotal(double price, int discount)
    {
        double DiscountFinal = (price * discount)/100;
        return price - DiscountFinal;
    }
    public double CalculateTotal(double price, double tax, int discount)
    {
        double DiscountFinal = (price * discount)/100;
        return (price+tax) - DiscountFinal;

    }

}