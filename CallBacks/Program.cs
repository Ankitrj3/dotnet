namespace CallBackUsingDelegate
{
    public delegate void CallBackUsingDelegate(string msg);
    public class Printer
    {
        public void Print(string msg, CallBackUsingDelegate callBack)
        {
            Console.WriteLine("Printing Started.....");
            callBack.Invoke(msg);
        }
    }
    public class Program
    {
        public static void Show(string msg)
        {
            Console.WriteLine("CallBack Function Calling.... "+msg);
        }
        public static void Main()
        {
            Printer p = new Printer();
            CallBackUsingDelegate callBack = Show;
            p.Print("Ankit",callBack);
        }
    }
}