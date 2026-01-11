using System.Text.RegularExpressions;

namespace Delegates
{
    // multicast delegates
    public delegate void Mydelegate(string? msg);
    // multicast delegates
    public class Program
    {
        public static void Main(string[] args)
        {
            PrintingCompany pc = new PrintingCompany();
            pc.CustomerFeedbackMessage = new PrintMessage(method1);
            pc.Print("ANkit");

            // multicast Delegates
            Mydelegate d = method2;
            d+=method3;
            d("Rocky");
            // multicast delegates
        }

        private static string method1(string message)
        {
            return "Welcome to Delegate World--------- "+ message;
        }
        private static string method4(string message)
        {
            return "Welcome to LPU. "+message;
        }
        private static void method2(string msg) // multicast delegates
        {
            Console.WriteLine("WELCOME " +msg);
        }
        private static void method3(string msg) // multicast delegates
        {
            Console.WriteLine("Not Welcome you can't go "+msg);
        }
    }
}