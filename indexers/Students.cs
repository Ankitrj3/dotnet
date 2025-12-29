using System.Security.AccessControl;

namespace Ankit
{
    class Students
    {
        public int RollNo {get; set;}
        public string? Name {get; set;} 
        private string? Address {get; set;} 

        public int PersonalId { get; private set;}
        private List<string> Books = new List<string>();

        // Constructor to set private Address
        public Students(string address = "")
        {
            Address = address;
        }

        // Public method to set Address
        public void SetAddress(string address)
        {
            Address = address;
        }

        // Public method to get Address
        public string GetAddress()
        {
            return Address;
        }

        public void setPersonalId(int id)
        {
            PersonalId = id;
        }

        public string? this[int index]{
            get
            {
                if(index < Books.Count)
                {
                    return Books[index];
                }
                return null;
            }
            set
            {
                if(index == Books.Count)
                {
                    Books.Add(value);
                }else if(index < Books.Count)
                {
                    Books[index] = value;
                }
            }
        }
    }
}