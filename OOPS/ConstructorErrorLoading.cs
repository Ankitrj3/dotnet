namespace Oops
{
    class ConstructorErrorLoading
    {
        #region Declaration
        public int id{ get; set; }
        private string name{ get; set; } // private varibles called fields 
        public string ErrorMessage{ get; set; } // public variables called member varibles
        #endregion

        #region Constructor
        public ConstructorErrorLoading(int id)
        {
            if(id < 1)
            {
                ErrorMessage += $"{DateTime.Now} ERROR! u can't enter value less then 1 {Environment.NewLine}";
            }
            this.id = id;
        }
        public ConstructorErrorLoading(int id, string name) : this(id)
        {
            if(name == "")
            {
                ErrorMessage += $"{DateTime.Now} ERROR! Name Can't be Empty";
            }
            this.name = name;

            Console.WriteLine(ErrorMessage);
        }
        }
        #endregion
    }
