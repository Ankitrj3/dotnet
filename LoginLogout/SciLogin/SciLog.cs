namespace LoginAccess
{
    public class SciLog : Login
    {
        public override void DoLogin(string username, string password)
        {
            Console.WriteLine("OK You are login in Science Lab Terminal ......");
        }

        public override void Logout()
        {
            Console.WriteLine("You Logged Out from Science Lab.......");
        }
    }
}