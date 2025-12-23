/// <summary>
/// ConstructorErrorLoading - Demonstrates error handling and logging in constructors
/// This class shows how to validate input parameters and log errors with timestamps
/// Also demonstrates the difference between private fields and public properties
/// </summary>
namespace Oops
{
    class ConstructorErrorLoading
    {
        #region Declaration
        public int id{ get; set; }              // Public property - accessible from outside
        private string name{ get; set; }        // Private field - only accessible within class
        public string ErrorMessage{ get; set; } // Public property to store error messages
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor with ID parameter
        /// Validates ID and logs error if invalid
        /// </summary>
        /// <param name="id">Unique identifier (must be greater than 0)</param>
        public ConstructorErrorLoading(int id)
        {
            // Validate ID - must be positive
            if(id < 1)
            {
                // Log error with timestamp if ID is invalid
                ErrorMessage += $"{DateTime.Now} ERROR! u can't enter value less then 1 {Environment.NewLine}";
            }
            this.id = id; // Assign ID regardless of validation (for demonstration)
        }
        
        /// <summary>
        /// Constructor with ID and Name parameters
        /// Chains to single-parameter constructor and validates name
        /// Displays all accumulated error messages
        /// </summary>
        /// <param name="id">Unique identifier</param>
        /// <param name="name">Person's name (cannot be empty)</param>
        public ConstructorErrorLoading(int id, string name) : this(id) // Call single-parameter constructor first
        {
            // Validate name - cannot be empty
            if(name == "")
            {
                // Log error with timestamp if name is empty
                ErrorMessage += $"{DateTime.Now} ERROR! Name Can't be Empty";
            }
            this.name = name; // Assign name regardless of validation

            // Display all error messages accumulated during construction
            Console.WriteLine(ErrorMessage);
        }
        #endregion
    }
}
