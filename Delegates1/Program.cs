namespace DelegateBasics
{
    // 1st Example of Delegate
    // Basic Deligate
    public delegate int Operation(int x, int y);
    public class Program
    {
        public static void Main()
        {
            Operation operation = new Operation(Sub);
            Console.WriteLine(operation(12,34));
        }
        private static int Add(int x, int y)
        {
            return x + y;
        }
        private static int Sub(int x, int y)
        {
            return x - y;
        }
    }
}