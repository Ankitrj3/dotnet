using System.Net;

namespace FileDownload
{
    public delegate void CallbackNotification(string message);
    public class FileDownload
    {
        public void DownloadFile(CallbackNotification callback)
        {
            Console.WriteLine("Downloading File.....");
            callback.Invoke("Downloaded The File");
        }
    }
    public class Program
    {
        public static void Main()
        {
            FileDownload fd = new FileDownload();
            CallbackNotification cb = Notification;
            fd.DownloadFile(cb);
        }
        private static void Notification(string message)
        {
            Console.WriteLine("Customer Downloaded the FILE "+message);
        }
    }
}