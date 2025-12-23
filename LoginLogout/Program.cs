using LoginAccess;

namespace LoginLogout
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Login lg = new LoginImp();   

            lg.DoLogin("Ankit", "Password");
            lg.LoginProcess();
            lg.Logout();

            Login login = new SciLog(); 
            login.DoLogin("Ankit", "123");
            login.Logout();
        }
    }
}
