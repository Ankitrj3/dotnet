using System.Dynamic;

namespace information
{
    public class Employee
    {
        public int Emp_ID{get; set;}
        public string Name{get; set;}
        public double Emp_Salary{get; set;}

        public Employee()
        {
            
        }

        public Employee(int Emp_ID, string Name, double Emp_Salary)
        {
            this.Emp_ID = Emp_ID;
            this.Name = Name;
            this.Emp_Salary = Emp_Salary;
        }
    }
}