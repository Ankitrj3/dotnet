namespace LoginAccess
{
    public class LoginImp : Login
    {
        public override void DoLogin(string username, string password)
        {
            Console.WriteLine("You are Logged in");
        }

        public override void Logout()
        {
            Console.WriteLine("You are Logged out");
        }
        
    }
}
