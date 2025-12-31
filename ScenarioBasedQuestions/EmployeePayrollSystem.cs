// Question 2: Inheritance – Employee Payroll System
// Design a base Employee class and derived classes FullTimeEmployee and ContractEmployee with different salary calculations.

using System.ComponentModel.DataAnnotations;
namespace PayRoll
{
    public class EmployeePayrollSystem
    {
        public string Emp_ID{get; set;}
        public string Name{get; set;}
        public string Emp_Role{get; set;}

        public EmployeePayrollSystem()
        {
            
        }
        public EmployeePayrollSystem(string Emp_ID, string Name, string Emp_Role)
        {
            this.Emp_ID = Emp_ID;
            this.Name = Name;
            this.Emp_Role = Emp_Role;
        }
        public virtual void SalaryCalculate()
        {
            
        }
    }
    public class FullTimeEmployee : EmployeePayrollSystem
    {
        public int Total_Days{get; set;}
        public FullTimeEmployee(){}
        public FullTimeEmployee(string Emp_ID,string Name,string Emp_Role,int Total_Days) : base(Emp_ID,Name,Emp_Role)
        {
            this.Total_Days = Total_Days;
        }
        public override void SalaryCalculate()
        {
            double Bonus = 10000;
            double BaseAmountPerDay = 800;
            double Total_Salary = (Total_Days * BaseAmountPerDay) + Bonus;
            Console.WriteLine($"Salary of FullTimeEmployee Employee : {Total_Salary}");
        }
    }
    public class ContractEmployee : EmployeePayrollSystem
    {
        public float Total_Hours{get; set;}
        public ContractEmployee(){}
        public ContractEmployee(string Emp_ID,string Name,string Emp_Role,float Total_Hours) : base(Emp_ID,Name,Emp_Role)
        {
            this.Total_Hours = Total_Hours;
        }
        public override void SalaryCalculate()
        {
            double BaseAmountPerHour = 2000;
            double Total_Salary = (Total_Hours * BaseAmountPerHour);
            Console.WriteLine($"Salary of Contract Employee : {Total_Salary}");
        }
    }
}