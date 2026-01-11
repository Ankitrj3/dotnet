namespace DelegateExample
{
    public class Program
    {
        // Delegate as Method Parameter
        public delegate bool Operation(int n);
        public static bool IsEven(int n)
        {
            return n%2==0;
        }
        public static bool IsOdd(int n)
        {
            return n%2!=0;
        }
        public static void PrintNumbers(List<int>list, Operation operation)
        {
            foreach(int n in list)
            {
                if (operation(n))
                {
                    Console.WriteLine(n);
                }
            }
        }
        public static void Main()
        {
            List<int>list = new List<int>();
            list.Add(12);
            list.Add(4);
            list.Add(3);
            list.Add(5);
            PrintNumbers(list, IsOdd);
            PrintNumbers(list,IsEven);
        }
    }
}