using System;
using System.Collections.Generic;
using Abstraction;
using Bank;
using Payment;
using PayRoll;
using Notification;

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

        // Question 3: Polymorphism – Online Payment Gateway
        // Design a payment system supporting CreditCard, UPI, and NetBanking using a single ProcessPayment() method.

        PaymentGateway pm = new UPIPayments();
        PaymentGateway pm1 = new CreditCard();
        PaymentGateway pm2 = new NetBanking();
        pm.ProcessPayment();
        pm1.ProcessPayment();
        pm2.ProcessPayment();

        // Question 4: Abstraction – Vehicle Rental System
        // Design an abstract Vehicle class for Car, Bike, and Truck with different rental price calculations.
        VehicleRentalSystem v1 = new Car(23);
        VehicleRentalSystem v2 = new Bike(12);
        VehicleRentalSystem v3 = new Truck(34);
        v1.Calculation();
        v2.Calculation();
        v3.Calculation();

        // Question 5: Interface – Notification System
        // Design a notification system supporting Email, SMS, and WhatsApp without changing core logic.
        
        // SMS Notification
        INotification sms = new SMS();
        NotificationService smsService = new NotificationService(sms);
        smsService.sentMessage("Hello Ankit");

        // Email Notification
        INotification email = new Email();
        NotificationService emailService = new NotificationService(email);
        emailService.sentMessage("Welcome to our platform");

        // WhatsApp Notification
        INotification whatsapp = new WhatsApp();
        NotificationService whatsappService = new NotificationService(whatsapp);
        whatsappService.sentMessage("I m done with Everything don't message me again");

        // Question 6: Method Overloading – Billing System
        // Design a billing module that calculates total price with different combinations of tax and discount.
        BillingSystem bill = new BillingSystem();
        Console.WriteLine("Only Price: " + bill.CalculateTotal(1000));
        Console.WriteLine("Price + Tax: " + bill.CalculateTotal(1000, 18));
        Console.WriteLine("Price + Discount: " + bill.CalculateTotal(1000, 10));
        Console.WriteLine("Price + Tax + Discount: " + bill.CalculateTotal(1000, 18, 10));

        // Question 7: Method Overriding – Insurance Premium Calculation
        // Design an Insurance base class and override CalculatePremium() for Health, Life, and Vehicle insurance.

        InsurancePayment insurancePayment = new CarInsurance();
        insurancePayment.CalculatePremium(3);
        InsurancePayment insurancePayment1 = new HealthInsurance();
        insurancePayment1.CalculatePremium(1);
        InsurancePayment insurancePayment2 = new LifeInsurance();
        insurancePayment2.CalculatePremium(2);


        // Question 8: Composition – Order and Product Relationship
        // Explain and design Order and Product classes using composition instead of inheritance.
        OrderAndProductRelationship product1 = new OrderAndProductRelationship("H10393","ICE CREAM",299);
        OrderAndProductRelationship product2 = new OrderAndProductRelationship("H23345","MAGGIE",10);

        OrderSystem od = new OrderSystem("OD12242");
        od.AddProduct(product1);
        od.AddProduct(product2);
        double price = od.PriceCalculation();
        Console.WriteLine(price);

        // Question 9: Interface vs Abstract Class – Reporting Module
        // Design a reporting system for PDF, Excel, and CSV formats and justify interface or abstract class usage.
        IOReportingSystem rs = new ReportingSystem();
        rs.GenerateReport();
        IOReportingSystem rs1 = new CSV();
        rs1.GenerateReport();
        IOReportingSystem rs2 = new Excel();
        rs2.GenerateReport();
    }
}
}