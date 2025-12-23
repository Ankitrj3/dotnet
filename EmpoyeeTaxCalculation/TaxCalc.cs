using System;

namespace AbstractionOOPS
{
    public abstract class TaxCalc
    {
        public abstract void CalTax(double income);
    }

    public class IndianEmp : TaxCalc
    {
        public override void CalTax(double income)
        {
            double finalSalary = income;

            if (income > 1200000)
            {
                double tax = income * 0.30;
                finalSalary = income - tax;
            }

            Console.WriteLine("Salary for Indian emp " + finalSalary);
        }
    }

    public class USEmp : TaxCalc
    {
        public override void CalTax(double income)
        {
            double finalSalary = income;

            if (income > 1200000)
            {
                double tax = income * 0.40;
                finalSalary = income - tax;
            }

            Console.WriteLine("Salary for US emp " + finalSalary);
        }
    }
}
