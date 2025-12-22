using System;
namespace Oops
{
    class ConstructorOverloading1
    {
        public int a{get; set;}
        public int b{get; set;}
        public int c{get; set;}
        public ConstructorOverloading1()
        {
            Console.WriteLine("No Arguments has been passed");
        }
        public ConstructorOverloading1(int a, int b)
        {
            this.a = a;
            this.b = b;
            Console.WriteLine(a+b);
        }
        public ConstructorOverloading1(int a , int b , int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Console.WriteLine(a+b+c);
        }
    }
}