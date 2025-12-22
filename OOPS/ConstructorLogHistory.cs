using System;

namespace Oops
{
    class ConstructorLogHistory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Requirement { get; set; }
        public string LogHistory { get; set; }

             public ConstructorLogHistory()
        {
            LogHistory = "";
            LogHistory += $"Object created at {DateTime.Now}{Environment.NewLine}";
        }

        public ConstructorLogHistory(int id) : this()
        {
            Id = id;
            LogHistory += $"Id set to {id} at {DateTime.Now}{Environment.NewLine}";
        }
        public ConstructorLogHistory(int id, string name) : this(id)
        {
            if (name.ToLower().Contains("idiot"))
            {
                throw new ArgumentException("You are Idiot, don't type Idiot");
            }

            Name = name;
            LogHistory += $"Name set to {name} at {DateTime.Now}{Environment.NewLine}";
        }

        
        public ConstructorLogHistory(int id, string name, string requirement) : this(id, name)
        {
            Requirement = requirement;
            LogHistory += $"Requirement set to {requirement} at {DateTime.Now}{Environment.NewLine}";

            Console.WriteLine(LogHistory);
        }
    }
}
