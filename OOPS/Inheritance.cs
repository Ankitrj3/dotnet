namespace Oops
{
    public class Inheritance
    {
        private int AccountId{ get; set; }
        private int id{ get; set; }
        public string GetAccountDetails(int AccountId)
        {
            return $"You Account Id {AccountId}";
        }
    }
    public class Derived : Inheritance
    {
        public string GetDetails(int Id)
        {
            return $"You Account Id {Id}";
        }
    }
    public class Derived1 : Derived
    {
        public string GetFullDetails(int AccountId, int Id)
        {
            string fullDetails = base.GetDetails(Id);
            fullDetails += $"{Environment.NewLine}";
            fullDetails += base.GetAccountDetails(AccountId);
            fullDetails += $"{Environment.NewLine}";
            fullDetails += "Your Full Details !";
            return fullDetails;
        }
    }
}