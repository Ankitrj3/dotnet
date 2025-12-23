namespace LoginAccess
{
    public abstract class Login
    {
        public abstract void DoLogin(string username, string password);
        public abstract void Logout();
        public void LoginProcess()
        {
            Console.WriteLine("LoginProcess......");
        }
    }
}
