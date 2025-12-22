using System;

/// <summary>
/// ConstructorOverloading1 - Another example of constructor overloading
/// Demonstrates mathematical operations in constructors and console output
/// </summary>
namespace Oops
{
    class ConstructorOverloading1
    {
        // Properties to store integer values
        public int a{get; set;}  // First number
        public int b{get; set;}  // Second number  
        public int c{get; set;}  // Third number
        
        /// <summary>
        /// Default constructor - No parameters
        /// Simply displays a message indicating no arguments were passed
        /// </summary>
        public ConstructorOverloading1()
        {
            Console.WriteLine("No Arguments has been passed");
        }
        
        /// <summary>
        /// Constructor with two parameters
        /// Performs addition of two numbers and displays the result
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        public ConstructorOverloading1(int a, int b)
        {
            // Store the parameter values in instance properties
            this.a = a;
            this.b = b;
            
            // Calculate and display the sum of two numbers
            Console.WriteLine(a+b);
        }
        
        /// <summary>
        /// Constructor with three parameters
        /// Performs addition of three numbers and displays the result
        /// </summary>
        /// <param name="a">First number</param>
        /// <param name="b">Second number</param>
        /// <param name="c">Third number</param>
        public ConstructorOverloading1(int a , int b , int c)
        {
            // Stormeter values in instance properties
            this.a = a;
            this.b = b;
            this.c = c;
            
            // Calculate and display the sum of three numbers
            Console.WriteLine(a+b+c);
        }
    }
}