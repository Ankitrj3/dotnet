/// <summary>
/// ConstructorOverloading - Demonstrates constructor overloading concept
/// Shows how multiple constructors can exist with different parameter combinations
/// Also includes input validation and exception handling
/// </summary>
namespace Oops{
    class ConstructorOverloading
    {
        // Auto-implemented properties to store object data
        public int id{ get; set; }           // Unique identifier
        public string name{ get; set; }      // Person's name
        public string requirement{ get; set;} // Skills or requirements
        
        /// <summary>
        /// Default constructor - No parameters
        /// Creates an object with default/uninitialized values
        /// </summary>
        public ConstructorOverloading()
        {
            // Empty constructor body - properties will have default values
        }
        
        /// <summary>
        /// Constructor with one parameter - ID only
        /// </summary>
        /// <param name="id">Unique identifier</param>
        public ConstructorOverloading(int id)
        {
            this.id = id; // Initialize only the ID property
        }
        
        /// <summary>
        /// Constructor with two parameters - ID and Name
        /// Includes input validation to prevent inappropriate names
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="name">Person's name</param>
        /// <exception cref="ArgumentException">Thrown when name contains inappropriate content</exception>
        public ConstructorOverloading(int id, string name)
        {
            this.id = id;
            
            // Input validation - check for inappropriate content
            if (name.ToLower().Contains("idiot"))
            {
                // Throw exception if validation fails
                throw new ArgumentException("You are Idiot don't type Idiot");
            }
            this.name = name;
        }
        
        /// <summary>
        /// Constructor with three parameters - ID, Name, and Requirements
        /// Most comprehensive constructor with all available properties
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="name">Person's name</param>
        /// <param name="requirement">Skills or requirements</param>
        public ConstructorOverloading(int id, string name, string requirement)
        {
            // Initialize all three properties
            this.id = id;
            this.name = name;
            this.requirement = requirement;
        }

    }
}