public class Bank
{
    public string? AccountNo{get; set;}
    public string? AccountHolder{get; set;}
    public double Balance{get; set;}
    public Bank(){}
}
public class BankService
{
    private Dictionary<string, Bank> _account = new Dictionary<string, Bank>();

    public void AddBankAccount(Bank account)
    {
        if (!_account.ContainsKey(account.AccountNo))
        {
            _account.Add(account.AccountNo,account);
        }
    }
    public void Deposit(string accountNo, double amount)
    {
        _account[accountNo].Balance += amount;
        Console.WriteLine($"In this account no -> {accountNo} you deposited this amount -> {amount}");
    }
    public void WithDraw(string accountNo, double amount)
    {
        if(_account[accountNo].Balance < amount)
        {
            throw new Exception("Not Sufficient Balance");
        }
        _account[accountNo].Balance -= amount;
        Console.WriteLine($"Balance After WithDraw is {_account[accountNo].Balance}");
    }
}