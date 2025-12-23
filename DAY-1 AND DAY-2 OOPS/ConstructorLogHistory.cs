using System;

/// <summary>
/// ConstructorLogHistory - Demonstrates constructor chaining and activity logging
/// This class shows how constructors can call other constructors using 'this' keyword
/// and maintains a log of all operations performed during object creation
/// </summary>
namespace Oops
{
    class ConstructorLogHistory
    {
        // Properties to store object data
        public int Id { get; set; }           // Unique identifier
        public string Name { get; set; }      // Person's name
        public string Requirement { get; set; } // Skills or requirements
        public string LogHistory { get; set; }   // Activity log with timestamps

        /// <summary>
        /// Default constructor - Creates initial log entry
        /// This constructor is called by all other constructors through chaining
        /// </summary>
        public ConstructorLogHistory()
        {
            // Initialize log with object creation timestamp
            LogHistory += $"Object created at {DateTime.Now}{Environment.NewLine}";
        }

        /// <summary>
        /// Constructor with ID parameter
        /// Chains to default constructor using 'this()' and adds ID logging
        /// </summary>
        /// <param name="id">Unique identifier</param>
        public ConstructorLogHistory(int id) : this() // Call default constructor first
        {
            Id = id;
            // Add ID assignment to log with timestamp
            LogHistory += $"Id set to {id} at {DateTime.Now}{Environment.NewLine}";
        }
        
        /// <summary>
        /// Constructor with ID and Name parameters
        /// Chains to single-parameter constructor and adds name validation/logging
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="name">Person's name</param>
        /// <exception cref="ArgumentException">Thrown when name contains inappropriate content</exception>
        public ConstructorLogHistory(int id, string name) : this(id) // Call ID constructor first
        {
            // Input validation - prevent inappropriate names
            if (name.ToLower().Contains("idiot"))
            {
                throw new ArgumentException("You are Idiot, don't type Idiot");
            }

            Name = name;
            // Add name assignment to log with timestamp
            LogHistory += $"Name set to {name} at {DateTime.Now}{Environment.NewLine}";
        }

        /// <summary>
        /// Constructor with all parameters (ID, Name, Requirement)
        /// Chains to two-parameter constructor and completes object initialization
        /// Displays complete log history when finished
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="name">Person's name</param>
        /// <param name="requirement">Skills or requirements</param>
        public ConstructorLogHistory(int id, string name, string requirement) : this(id, name) // Call two-parameter constructor first
        {
            Requirement = requirement;
            // Add requirement assignment to log with timestamp
            LogHistory += $"Requirement set to {requirement} at {DateTime.Now}{Environment.NewLine}";

            // Display complete construction history
            Console.WriteLine(LogHistory);
        }
    }
}
