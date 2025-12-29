namespace AnkitInterface
{
    interface LogIn
    {
        void logIn();
    }
    interface LogOut
    {
        void logOut();
    }
    abstract class ShashiInterface
    {
        public string name{ get; set; }
        public abstract void work();
        public ShashiInterface(string name)
        {
            this.name = name;
        }
    }
    class Ankit : ShashiInterface, LogIn, LogOut{
        public Ankit(string name): base(name){}
        public void logIn()
        {
            Console.WriteLine("You are Logged In");
        }
        public void logOut()
        {
            Console.WriteLine("You are Log out");
        }
        public override void work()
        {
            logIn();
            Console.WriteLine("You are working fine "+name);
            logOut();
        }
    }
}