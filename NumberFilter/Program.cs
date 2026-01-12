namespace Filter
{
    public delegate bool NumberFilter(int num);
    public class Program
    {
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
        public static void PrintNum(List<int> list, NumberFilter filter)
        {
            foreach (int n in list)
            {
                if (filter(n))
                {

                    Console.WriteLine(n);
                }
            }
        }

        public static void Main()
        {
            List<int> list = new List<int>();
            list.Add(12);
            list.Add(4);
            list.Add(3);
            NumberFilter filter = IsOdd;
            PrintNum(list, filter);
        }
    }
}