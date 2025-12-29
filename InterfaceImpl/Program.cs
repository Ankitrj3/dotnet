namespace AnkitInterface
{
    class Program
    {
        public static void Main(string [] args)
        {
            Ankit an = new Ankit("ankit");
            an.work();

            Showing h = new Showing();
            h.work();
            Hiding s = new Showing();
            s.work();

            Interfaces i = new Interfaces();
            i.Iprint();
        }
    }
}