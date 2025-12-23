using AbstractionOOPS;
class Program
{
    public static void Main(string [] args)
    {
        TaxCalc tc = new IndianEmp();
        tc.CalTax(1250000);
        TaxCalc tc1 = new USEmp();
        tc1.CalTax(1250000);
    } 
}