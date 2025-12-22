class Student
{
    // <Summary>
    // Student Defination
    // </Summary>
    
    #region Declaration
    public string Name;
    public int Age;
    public int Reg_No;
    public string Department;
    #endregion

    #region Constructor
    public Student(string name, int age, int reg_no, string department)
    {
        Name = name;
        Age = age;
        Reg_No = reg_no;
        Department = department;
    }
    #endregion

    #region Member functions
    public void Information()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Reg_No: " + Reg_No);
        Console.WriteLine("Deparment: " + Department);
    }
    #endregion
   }
