namespace AnkitInterface
{
    class Hiding
    {
        public virtual void work()
        {
            Console.WriteLine("I m parent class");
        }
    }
    class Showing : Hiding
    {
        public new void work()
        {
            Console.WriteLine("I m child Class");
        }
    }
}