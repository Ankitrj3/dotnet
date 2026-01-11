using System.Collections.Generic;
namespace Collections
{
    public class Generic1
    {
        public void Add<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            Console.WriteLine(num1 + num2);
        }
        public void Sub<T>(T a, T b)
        {
            dynamic num1 = a;
            dynamic num2 = b;
            Console.WriteLine(num1 - num2);
        }
    }
}