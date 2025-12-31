using System;
using System.Collections.Generic;
using Bank;
using PayRoll;

namespace Student{
class Program
{
    public static void Main(string [] args)
    {
        var listOfStu = DataBank.GetStudents();
        Console.WriteLine("Students in the system:");
        foreach(var student in listOfStu)
        {
            Console.WriteLine($"ID: {student.Id}, Name: {student.Name}");
        }

        var listOfStuSession = DataBank.GetStudentSessions();
        Console.WriteLine("Student Session ....");
        foreach(var studentSession in listOfStuSession)
            {
                Console.WriteLine($"Session id {studentSession.SessionId} , Name: {studentSession.Name}");
            }

        // Question 1: Encapsulation – Bank Account Security
        // Design a BankAccount class where balance is protected and can be accessed or modified only through secure methods like Deposit and Withdraw.

        // BankBalance account = new BankBalance(12000);
        // account.GetBalance();
        // account.Deposit(21324);
        // account.Withdraw(30000);

        // Question 2: Inheritance – Employee Payroll System
        // Design a base Employee class and derived classes FullTimeEmployee and ContractEmployee with different salary calculations.

        EmployeePayrollSystem full = new FullTimeEmployee(){Emp_ID="EMP01", Name="Ankit Ranjan", Emp_Role="Full Time Employee", Total_Days=29};
        EmployeePayrollSystem full1 = new ContractEmployee(){Emp_ID="EMP02", Name="All Likhitha Sri", Emp_Role="Contact Employee", Total_Hours=14};
        full.SalaryCalculate();
        full1.SalaryCalculate();
    }
}
}