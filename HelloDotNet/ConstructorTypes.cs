using System;

namespace ConstructorTypes
{
    public class ConstructorTypes
    {
        int x; int y;
        public ConstructorTypes()
        {
            Console.WriteLine("Default Constructor Called.....");
        }
        public ConstructorTypes(int a, int b)
        {
            Console.WriteLine(a+b);
            Console.WriteLine("Parameterized Constructor Called.....");
        }
        public ConstructorTypes(ConstructorTypes obj)
        {
            x = obj.x;
            Console.WriteLine(x+y);
            Console.WriteLine("Copy Constructor Called.....");
        }
        static ConstructorTypes()
        {
            Console.WriteLine("Static Constructor Called.....");
        }
    }
}