using System;

public class StudentInfo
{
    public string Name { get; set; }
    public int Reg_no { get; set; }
    public string School { get; set; }

    public StudentInfo(string name, int reg_no, string school)
    {
        Name = name;
        Reg_no = reg_no;
        School = school;
    }
}

public class UG : StudentInfo
{
    public string College { get; set; }

    public UG(string name, int reg_no, string school, string college)
        : base(name, reg_no, school)
    {
        College = college;
    }
}

public class PG : UG
{
    public string Department { get; set; }

    public PG(string name, int reg_no, string school, string college, string department)
        : base(name, reg_no, school, college)
    {
        Department = department;
    }
}

 