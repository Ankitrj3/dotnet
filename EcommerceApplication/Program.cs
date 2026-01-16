public class EcommerceApp
{
    public string? UserName{get; set;}
    public double WalletBalance{get; set;}
    public double TotalPurchaseAmount{get; set;}
    public EcommerceApp(){}
    public EcommerceApp(string u, double w, double t)
    {
        UserName = u;
        WalletBalance = w;
        TotalPurchaseAmount = t;
    }

}
public class InsufficientWalletBalanceException : Exception
{
    public override string Message => "Insufficient balance in your digital wallet";
}
public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter UserName");
            string? UserName = Console.ReadLine(); 
            Console.WriteLine("Enter Balance");
            string? Balance = Console.ReadLine();
            int balance = int.Parse(Balance);
            Console.WriteLine("Enter TotalPurchaseAmount");
            string? Amount = Console.ReadLine();
            int amount = int.Parse(Amount);
            EcommerceApp app = MakePayment(UserName,balance,amount);
            Console.WriteLine("Payment SuccessFull");
        }catch(InsufficientWalletBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
    }
    public static EcommerceApp MakePayment(string name, double balance, double amount)
    {
        if(balance < amount)
        {
            throw new InsufficientWalletBalanceException();
        }
        double Rembalance = balance - amount;
        return new EcommerceApp(name,Rembalance,amount);
    }
}