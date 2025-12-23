/// <summary>
/// Method Overriding Example - Demonstrates polymorphism in C#
/// Shows how derived classes can override virtual methods from base classes
/// Base Class: MethodOverriding -> Derived: Der -> Further Derived: Ankit
/// </summary>
namespace Oops
{
    /// <summary>
    /// Sealed class example - CreditCard
    /// 
    /// SEALED CLASS CHARACTERISTICS:
    /// - Cannot be inherited by other classes (sealed keyword prevents inheritance)
    /// - Provides final implementation that cannot be extended
    /// - Used when you want to prevent further derivation of a class
    /// - All methods in sealed class are implicitly final
    /// - Sealed classes are often used for security, performance, or design reasons
    /// 
    /// WHEN TO USE SEALED CLASSES:
    /// - When you want to prevent inheritance for security reasons
    /// - When the class represents a complete, final implementation
    /// - For performance optimization (sealed classes can have some runtime optimizations)
    /// - When you want to ensure the class behavior cannot be modified through inheritance
    /// </summary>
    sealed class CreditCard
    {
        /// <summary>
        /// Static method to display credit card information
        /// Since this is a sealed class, this method cannot be overridden
        /// Static methods don't require class instantiation
        /// </summary>
        public static void Card()
        {
            Console.WriteLine("We are coming soon");
        }
    }
    /// <summary>
    /// Base class demonstrating virtual method implementation
    /// Virtual methods can be overridden by derived classes to provide polymorphic behavior
    /// </summary>
    class MethodOverriding
    {
        /// <summary>
        /// Virtual method that can be overridden in derived classes
        /// The 'virtual' keyword allows method overriding
        /// </summary>
        /// <returns>String identifying this as the base class</returns>
        public virtual string Implementation()
        {
            return "I m the base class";
        }
    }
    
    /// <summary>
    /// First derived class - Der
    /// Overrides the virtual method from base class
    /// </summary>
    class Der : MethodOverriding
    {
        /// <summary>
        /// Overridden method - provides derived class specific implementation
        /// The 'override' keyword indicates this method overrides the base virtual method
        /// </summary>
        /// <returns>String identifying this as the derived class</returns>
        public override string Implementation()
        {
            return "I m the derived class";
        }
    }
    
    /// <summary>
    /// Second level derived class - Ankit
    /// Further overrides the method, demonstrating multi-level method overriding
    /// </summary>
    class Ankit : Der
    {
        /// <summary>
        /// Further overridden method - provides most specific implementation
        /// This demonstrates how method overriding works through inheritance hierarchy
        /// </summary>
        /// <returns>String identifying this as the Ankit class</returns>
        public override string Implementation()
        {
            return "ankit class";
        }
    }
}