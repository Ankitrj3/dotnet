namespace Events
{
    public delegate void Notify(string message);
    public class OrderProcessing
    {
        public event Notify OrderPlaced;
        public void PrintOrder()
        {
            Console.WriteLine("Order Placed Successfully");
            if (OrderPlaced != null)
            {
                OrderPlaced.Invoke("Your Order is Confirmed");
            }
        }
    }
    public class Customer
    {
        public void OnOrderPlaced(string message)
        {
            Console.WriteLine("Customer Received Notification " + message);
        }
    }
    public class Program
    {
        public static void Main()
        {
            OrderProcessing op = new OrderProcessing();
            Customer cs = new Customer();
            op.OrderPlaced += cs.OnOrderPlaced;
            op.PrintOrder();
    }
    }
}