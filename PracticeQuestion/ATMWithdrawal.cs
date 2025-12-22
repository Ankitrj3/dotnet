/// <summary>
/// ATMWithdrawal - Simulates ATM withdrawal process with nested validation checks
/// Checks: 1. Card inserted, 2. PIN valid, 3. Balance sufficient
/// Demonstrates nested if statements for sequential validation
/// </summary>
class ATMWithdrawal
{
    /// <summary>
    /// Simulates ATM withdrawal with multiple validation steps
    /// </summary>
    /// <param name="cardInserted">Whether card is inserted</param>
    /// <param name="enteredPin">PIN entered by user</param>
    /// <param name="correctPin">Correct PIN for the card</param>
    /// <param name="accountBalance">Current account balance</param>
    /// <param name="withdrawalAmount">Amount to withdraw</param>
    public void ProcessWithdrawal(bool cardInserted, int enteredPin, int correctPin, 
                                 double accountBalance, double withdrawalAmount)
    {
        // First check: Is card inserted?
        if (cardInserted)
        {
            Console.WriteLine("Card detected...");
            
            // Second check: Is PIN correct?
            if (enteredPin == correctPin)
            {
                Console.WriteLine("PIN verified successfully...");
                
                // Third check: Is balance sufficient?
                if (accountBalance >= withdrawalAmount)
                {
                    // All checks passed - process withdrawal
                    double newBalance = accountBalance - withdrawalAmount;
                    Console.WriteLine($"Withdrawal successful!");
                    Console.WriteLine($"Amount withdrawn: ${withdrawalAmount:F2}");
                    Console.WriteLine($"Remaining balance: ${newBalance:F2}");
                }
                else
                {
                    // Insufficient balance
                    Console.WriteLine("Transaction failed: Insufficient balance");
                    Console.WriteLine($"Available balance: ${accountBalance:F2}");
                    Console.WriteLine($"Requested amount: ${withdrawalAmount:F2}");
                }
            }
            else
            {
                // Incorrect PIN
                Console.WriteLine("Transaction failed: Incorrect PIN");
                Console.WriteLine("Please try again with correct PIN");
            }
        }
        else
        {
            // No card inserted
            Console.WriteLine("Transaction failed: Please insert your card");
        }
    }
}