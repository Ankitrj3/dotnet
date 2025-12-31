// Question 1: Encapsulation – Bank Account Security
// Design a BankAccount class where balance is protected and can be accessed or modified only through secure methods like Deposit and Withdraw.

namespace Bank
{
    public class BankBalance{
        private double balance;

        public BankBalance()
        {
            
        }
        public BankBalance(double Amount)
        {
            if(Amount < 0)
            {
                throw new ArgumentException("Amount Can not be in Negative Value");
            }
            balance = Amount;
        }
        public void Deposit(double Amount)
        {
            if(Amount < 0)
            {
                throw new ArgumentException("Amount Can not be in Negative Value");
            }
            balance+=Amount;
            Console.WriteLine("Your Current Balance is "+balance);
        }
        public void Withdraw(double Amount)
        {
            if(Amount > balance)
            {
                Console.WriteLine("Insufficient Balance");
            }
            else
            {
                balance-=Amount;
                Console.WriteLine($"Your Withdraw amount is : {Amount}");
                Console.WriteLine("Your Current Balance is "+balance);
            }
        }
        public void GetBalance()
        {
            Console.WriteLine("Your Current Balance is "+balance);
        }
    }
}