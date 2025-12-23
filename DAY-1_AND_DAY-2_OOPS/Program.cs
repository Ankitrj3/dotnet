/// <summary>
/// OOPS Program - Demonstrates Object-Oriented Programming concepts
/// This program showcases inheritance, constructor overloading, method overriding, and error handling
/// </summary>
public class Program
{
    /// <summary>
    /// Main entry point demonstrating various OOP concepts
    /// Creates instances of different classes to show inheritance hierarchy,
    /// constructor overloading, method overriding, and exception handling
    /// </summary>
    public static void Main()
    {
        // Inheritance Example - Creating a PG (Post Graduate) student
        // PG inherits from UG, which inherits from StudentInfo (3-level inheritance)
        PG student = new PG(
            name: "Ankit",
            reg_no: 101,
            school: "ABC School",
            college: "XYZ Engineering College",
            department: "Computer Science"
        );

        // Display student information using inherited properties
        Console.WriteLine("---- Student Details ----");
        Console.WriteLine($"Name       : {student.Name}");
        Console.WriteLine($"Reg No     : {student.Reg_no}");
        Console.WriteLine($"School     : {student.School}");
        Console.WriteLine($"College    : {student.College}");
        Console.WriteLine($"Department : {student.Department}");

        // Constructor Overloading Examples
        // Default constructor (no parameters)
        Oops.ConstructorOverloading co = new Oops.ConstructorOverloading();
        
        // Constructor with one parameter (id only)
        Oops.ConstructorOverloading co1 = new Oops.ConstructorOverloading(
            12000999
        );
        Console.WriteLine(co1.id);
        
        // Constructor with two parameters (id and name) - includes exception handling
        try{
        Oops.ConstructorOverloading co2 = new Oops.ConstructorOverloading(
            12233444,
            "Shashi Mani IDIOT" // This will throw an exception due to "IDIOT" validation
        );
        Console.WriteLine(co2.id+" "+co2.name);
        }catch(Exception e)
        {
            // Handle the exception thrown by constructor validation
            Console.WriteLine(e.Message);
        }
        
        // Constructor with three parameters (id, name, and requirement)
        Oops.ConstructorOverloading co3 = new Oops.ConstructorOverloading(
            12000777,
            "ANkit Ranjan",
            ".Net,JAVA"
        );
        Console.WriteLine(co3.id+" "+co3.name+" "+co3.requirement);

        // Another Constructor Overloading Example
        Oops.ConstructorOverloading1 op1 = new Oops.ConstructorOverloading1(); // Default constructor
        Oops.ConstructorOverloading1 op2 = new Oops.ConstructorOverloading1(12, 34); // Two parameter constructor

        // Constructor with Logging History - demonstrates constructor chaining
        Oops.ConstructorLogHistory o1 = new Oops.ConstructorLogHistory(12,"ankit","cse");

        // Constructor Error Loading - demonstrates error handling in constructors
        Oops.ConstructorErrorLoading er = new Oops.ConstructorErrorLoading(
            -12, // Negative ID will trigger error logging
            ""   // Empty name will trigger error logging
        );
        
        // Inheritance Example - Multi-level inheritance demonstration
        Oops.Derived1 ni = new Oops.Derived1();
        string fulldetails = ni.GetFullDetails(120007777,34);
        Console.WriteLine(fulldetails);

        // Method Overriding Example - Polymorphism demonstration
        // Base class reference pointing to derived class object
        Oops.MethodOverriding d = new Oops.Ankit();
        string d1 = d.implementation(); // Calls overridden method in Ankit class
        Console.WriteLine(d1);

    }
}