namespace Delegates
{
    public delegate string PrintMessage(string message);

    public class PrintingCompany
    {
        public PrintMessage CustomerFeedbackMessage{get; set;}

        public void Print(string message)
        {
            string? messageToPrint = CustomerFeedbackMessage(message);
            Console.WriteLine(messageToPrint);
        }
    }
}