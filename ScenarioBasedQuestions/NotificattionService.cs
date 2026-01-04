namespace Notification
{
    public class NotificationService
    {
        private readonly INotification _INotification;

        public NotificationService()
        {

        }
        public NotificationService(INotification _INotification)
        {
            this._INotification = _INotification;
        }
        public void sentMessage(string Message)
        {
            _INotification.Notification(Message);
        }
    }

}