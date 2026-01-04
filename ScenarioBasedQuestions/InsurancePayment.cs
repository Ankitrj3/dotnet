// Question 7: Method Overriding – Insurance Premium Calculation
// Design an Insurance base class and override CalculatePremium() for Health, Life, and Vehicle insurance.

public abstract class InsurancePayment
{
    public void InsuraceInfo()
    {
        Console.WriteLine("Insurance Pays");
    }
    public abstract void CalculatePremium(double year);
}
public class HealthInsurance : InsurancePayment
{
    public override void CalculatePremium(double year)
    {
        double InsurancePrice = 23440;
        Console.WriteLine($"The Health Insurance Price for {year} years : {InsurancePrice}");
    }
}
public class CarInsurance : InsurancePayment
{
    public override void CalculatePremium(double year)
    {
        double InsurancePrice = 16000;
        Console.WriteLine($"The Car Insurance Price for {year} years : {InsurancePrice}");
    }
}
public class LifeInsurance : InsurancePayment
{
    public override void CalculatePremium(double year)
    {
        double InsurancePrice = 50000;
        Console.WriteLine($"The Life Insurance Price for {year} years : {InsurancePrice}");
    }
}
