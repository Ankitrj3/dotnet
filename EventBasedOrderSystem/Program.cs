namespace OrderSystem
{
    public delegate void OrderNotify(string msg);
    public class OrderProcessing
    {
        public event OrderNotify? OrderPlaced;
        public void PrintOrder()
        {
            Console.WriteLine("Order Processing.....");
            if (OrderPlaced != null)
            {
                OrderPlaced.Invoke("Your Order has Been Placed...");
            }
        }
    }
    public class Customer
    {
        public void OnOrderPlaced(string msg)
        {
            Console.WriteLine("Order has been Placed Successfully " + msg);
        }
    }
    public class Program
    {
        public static void Main()
        {
            OrderProcessing od = new OrderProcessing();
            Customer cs = new Customer();

            od.OrderPlaced += cs.OnOrderPlaced;
            od.PrintOrder();
        }
    }
}