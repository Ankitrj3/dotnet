// Question 5: Interface – Notification System
// Design a notification system supporting Email, SMS, and WhatsApp without changing core logic.
namespace Notification
{
    public interface INotification
    {
        public void Notification(string Message);
    }
    public class NotificationSystem : INotification
    {
        public void Notification(string Message)
        {
            Console.WriteLine(Message);
        }
    }
    public class Email : INotification
    {
        public void Notification(string Message)
        {
            Console.WriteLine($"{Message} -> This Email Sent Successfully");
        }
    }
    public class SMS : INotification
    {
        public void Notification(string Message)
        {
            Console.WriteLine($"{Message} -> This SMS Sent Successfully");
        }
    }
    public class WhatsApp : INotification
    {
        public void Notification(string Message)
        {
            Console.WriteLine($"{Message} -> This WhatsApp Sent Successfully");
        }
    }

}