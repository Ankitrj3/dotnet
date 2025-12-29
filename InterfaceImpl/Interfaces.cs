namespace AnkitInterface{
    interface Iprint
    {
        void Iprint();
    }
    public class Interfaces : Iprint
    {
        public void Iprint()
        {
            Console.WriteLine("Hello..... guys");
        }
    }   
}