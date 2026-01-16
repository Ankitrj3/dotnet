using System.Dynamic;
using System.Collections.Generic;
namespace EmployeeFeature
{
    public class Employee
    {
        public string Emp_Name{get; set;}
        public int Emp_ID{get; set;}
        public string Designation{get; set;}
        public double Emp_Salary{get; set;}

        public Employee(){}
        public Employee(string Emp_Name, int Emp_ID, string Designation, double Emp_Salary)
        {
            this.Emp_Name = Emp_Name;
            this.Emp_ID = Emp_ID;
            this.Designation = Designation;
            this.Emp_Salary = Emp_Salary;
        }
    }
    public class EmployeeService
    {
        public string GetAllEmployeeNames(IList<Employee> employees)
        {
            string result = "";
            foreach(Employee e in employees)
            {
                result += $"{e.Emp_Name}, ";
            }
            result = result.TrimEnd(',',' ');
            return result;
        }
        public double GetAverageSalary(IList<Employee> employees)
        {
            double avg = 0;
            int count = 0;
            foreach(Employee e in employees)
            {
                avg += e.Emp_Salary;
                count++;
            }
            return avg/count;
        }
        public double GetMaxSalary(IList<Employee> employees)
        {
            double max = 0;
            foreach(Employee e in employees)
            {
                if(e.Emp_Salary > max)
                {
                    max = e.Emp_Salary;
                }
            }
            return max;
        }
        public double SecondMaxSalary(IList<Employee> employees)
        {
            double max = int.MinValue;
            double secondHighest = int.MinValue;
            foreach(Employee e in employees)
            {
                if(e.Emp_Salary > max)
                {
                    secondHighest = max;
                    max = e.Emp_Salary;
                }else if(e.Emp_Salary > secondHighest && e.Emp_Salary < max)
                {
                    secondHighest = e.Emp_Salary;
                }
            }
            return secondHighest;
        }
    }
}