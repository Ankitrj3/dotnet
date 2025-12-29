using System.Runtime.CompilerServices;

namespace Manager
{
    interface UserLogin
    {
        void LoggedIn();
        void LoggedOut();
    }
    interface Employee
    {
        void EmpInfo(string name, string id);
    }
    public abstract class HRManager
    {
        public void Salary()
        {
            Console.WriteLine("Salary will Only Manage by HR Team");
        }
        public abstract void LanguagePreference(string lang);
        public abstract void CheckInAndCheckOut();
        
    }

    public class TechTeam : Employee, HRManager, UserLogin
    {
        public void EmpInfo(string name, string id)
        {
            
        }
    }
    
}