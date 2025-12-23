using PaymentsUPI;

class Program
{
    public static void Main(string [] args)
    {
        UpiPayments upi = new Payment(12232.23,"ankitrocky1@ybl");
        upi.Pay();
        upi.PayRecipt();
    }
}