using System;

/// <summary>
/// StudentInfo - Base class in the inheritance hierarchy
/// Represents basic student information with name, registration number, and school
/// </summary>
public class StudentInfo
{
    // Auto-implemented properties for encapsulation
    public string Name { get; set; }     // Student's full name
    public int Reg_no { get; set; }      // Student's registration number
    public string School { get; set; }   // Student's school name

    /// <summary>
    /// Constructor to initialize basic student information
    /// </summary>
    /// <param name="name">Student's name</param>
    /// <param name="reg_no">Student's registration number</param>
    /// <param name="school">Student's school</param>
    public StudentInfo(string name, int reg_no, string school)
    {
        Name = name;
        Reg_no = reg_no;
        School = school;
    }
}

/// <summary>
/// UG (Under Graduate) - Inherits from StudentInfo
/// Adds college information to the base student information
/// Demonstrates single inheritance
/// </summary>
public class UG : StudentInfo
{
    public string College { get; set; }  // Student's college name

    /// <summary>
    /// Constructor for UG student
    /// Uses base constructor to initialize inherited properties
    /// </summary>
    /// <param name="name">Student's name</param>
    /// <param name="reg_no">Student's registration number</param>
    /// <param name="school">Student's school</param>
    /// <param name="college">Student's college</param>
    public UG(string name, int reg_no, string school, string college)
        : base(name, reg_no, school) // Call base class constructor
    {
        College = college;
    }
}

/// <summary>
/// PG (Post Graduate) - Inherits from UG
/// Adds department information to UG student information
/// Demonstrates multi-level inheritance (StudentInfo -> UG -> PG)
/// </summary>
public class PG : UG
{
    public string Department { get; set; }  // Student's department/specialization

    /// <summary>
    /// Constructor for PG student
    /// Uses base constructor to initialize all inherited properties
    /// </summary>
    /// <param name="name">Student's name</param>
    /// <param name="reg_no">Student's registration number</param>
    /// <param name="school">Student's school</param>
    /// <param name="college">Student's college</param>
    /// <param name="department">Student's department</param>
    public PG(string name, int reg_no, string school, string college, string department)
        : base(name, reg_no, school, college) // Call UG constructor
    {
        Department = department;
    }
}

 