namespace PaymentsUPI
{
    abstract class UpiPayments
    {
        public double amount;
        protected UpiPayments(double amount)
        {
            this.amount = amount;
        }

        public void PayRecipt()
        {
            Console.WriteLine($"Payment Receipt {amount}");
        }
        public abstract void Pay();
    }
    class Payment : UpiPayments 
    {
        public string upiID;
        public Payment(double amount , string upiID) : base(amount)
        {
            this.upiID = upiID;
        }
        public override void Pay()
        {
            Console.WriteLine($"Amount -> {amount} Paid to this {upiID} ");
        }
    }
}