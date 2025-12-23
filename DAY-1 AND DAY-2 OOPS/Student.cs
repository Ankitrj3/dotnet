/// <summary>
/// Student class - Demonstrates basic class structure with properties and methods
/// This class represents a student with basic information and display functionality
/// </summary>
class Student
{
    // <Summary>
    // Student Defination
    // </Summary>
    
    #region Declaration - Public fields to store student information
    public string Name;        // Student's full name
    public int Age;            // Student's age in years
    public int Reg_No;         // Student's registration number
    public string Department;  // Student's department/major
    #endregion

    #region Constructor
    /// <summary>
    /// Parameterized constructor to initialize a Student object
    /// </summary>
    /// <param name="name">Student's name</param>
    /// <param name="age">Student's age</param>
    /// <param name="reg_no">Student's registration number</param>
    /// <param name="department">Student's department</param>
    public Student(string name, int age, int reg_no, string department)
    {
        // Initialize all fields with provided parameters
        Name = name;
        Age = age;
        Reg_No = reg_no;
        Department = department;
    }
    #endregion

    #region Member functions
    /// <summary>
    /// Displays all student information to the console
    /// </summary>
    public void Information()
    {
        // Print each field with a descriptive label
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Reg_No: " + Reg_No);
        Console.WriteLine("Deparment: " + Department);
    }
    #endregion
   }
