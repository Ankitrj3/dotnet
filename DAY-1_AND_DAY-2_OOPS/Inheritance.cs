/// <summary>
/// Inheritance Example - Demonstrates multi-level inheritance in C#
/// Shows how derived classes can inherit and extend functionality from base classes
/// Base Class: Inheritance -> Derived Class: Derived -> Further Derived: Derived1
/// </summary>
namespace Oops
{
    /// <summary>
    /// Base class - Inheritance
    /// Contains basic account functionality
    /// </summary>
    public class Inheritance
    {
        // Private properties - only accessible within this class
        private int AccountId{ get; set; }  // Account identifier (unused in current implementation)
        private int id{ get; set; }         // General ID (unused in current implementation)
        
        /// <summary>
        /// Method to get account details
        /// Returns formatted account information
        /// </summary>
        /// <param name="AccountId">Account identifier</param>
        /// <returns>Formatted account details string</returns>
        public string GetAccountDetails(int AccountId)
        {
            return $"You Account Id {AccountId}";
        }
    }
    
    /// <summary>
    /// First level derived class - Derived
    /// Inherits from Inheritance class and adds ID functionality
    /// /// </summary>
    public class Derived : Inheritance
    {
        /// <summary>
        /// Method tobasic ID details
        /// Extends base class functionality
        /// </summary>
        /// <param name="Id">User identifier</param>
        /// <returns>Formatted ID details string</returns>
        public string GetDetails(int Id)
        {
            return $"You Id {Id}";
        }
    }
    
    /// <summary>
    /// Second level derived class - Derived1
    /// Inherits from Derived class (which inherits from Inheritance)
    /// Demonstrates multi-level inheritance and method composition
    /// </summary>
    public class Derived1 : Derived
    {
        /// <summary>
        /// Method that combines functionality from both parent classes
        /// Calls methods from base classes to create comprehensive details
        /// </summary>
        /// <param name="AccountId">Account identifier</param>
        /// <param name="Id">User identifier</param>
        /// <returns>Complete details combining account and user information</returns>
        public string GetFullDetails(int AccountId, int Id)
        {
            // Call method from grandparent class (Derived -> Inheritance)
            string fullDetails = base.GetDetails(Id);
            fullDetails += $"{Environment.NewLine}";
            
            // Call method from great-grandparent class (Derived1 -> Derived -> Inheritance)
            fullDetails += base.GetAccountDetails(AccountId);
            fullDetails += $"{Environment.NewLine}";
            
            // Add additional information specific to this class
            fullDetails += "Your Full Details !";
            return fullDetails;
        }
    }
}