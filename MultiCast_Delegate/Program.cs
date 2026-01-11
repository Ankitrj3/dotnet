namespace MultiCastDelegateExample
{
    public class Program
    {
        public delegate void Notify();
        public static void Main()
        {
            Notify m = SMS;
            m += EMAIL;
            m();
        }
        private static void SMS()
        {
            Console.WriteLine("SMS Sent");
        }
        private static void EMAIL()
        {
            Console.WriteLine("EMAIL Sent");
        }
    }
}