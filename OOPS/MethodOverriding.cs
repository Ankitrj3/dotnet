/// <summary>
/// Method Overriding Example - Demonstrates polymorphism in C#
/// Shows how derived classes can override virtual methods from base classes
/// Base Class: MethodOverriding -> Derived: Der -> Further Derived: Ankit
/// </summary>
namespace Oops
{
    /// <summary>
    /// Base class with virtual method
    /// Virtual methods can be overridden by derived classes
    /// </summary>
    class MethodOverriding
    {
        /// <summary>
        /// Virtual method that can be overridden in derived classes
        /// The 'virtual' keyword allows method overriding
        /// </summary>
        /// <returns>String identifying this as the base class</returns>
        public virtual string implementation()
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
        public override string implementation()
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
        public override string implementation()
        {
            return "ankit class";
        }
    }
}