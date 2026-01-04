// Question 3: Polymorphism – Online Payment Gateway
// Design a payment system supporting CreditCard, UPI, and NetBanking using a single ProcessPayment() method.

namespace Payment
{
    public abstract class PaymentGateway
    {
        public abstract void ProcessPayment();
    }
    public class UPIPayments : PaymentGateway
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("UPI Done.....");
        }
    }
    public class CreditCard : PaymentGateway
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("Credit_Card Done.....");
        }
    }
    public class NetBanking : PaymentGateway
    {
        public override void ProcessPayment()
        {
            Console.WriteLine("NetBanking Done.....");
        }
    }
}