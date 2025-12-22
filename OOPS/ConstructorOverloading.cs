namespace Oops{
    class ConstructorOverloading
    {
        public int id{ get; set; }
        public string name{ get; set; }
        public string requirement{ get; set;}
        

        public ConstructorOverloading()
        {
        
        }
        public ConstructorOverloading(int id)
        {
            this.id = id;
        }
        public ConstructorOverloading(int id, string name)
        {
            this.id = id;
            if (name.ToLower().Contains("idiot"))
            {
                throw new ArgumentException("You are Idiot don't type Idiot");
            }
            this.name = name;
        }
        public ConstructorOverloading(int id, string name, string requirement)
        {
            this.id = id;
            this.name = name;
            this.requirement = requirement;
        }

    }
}