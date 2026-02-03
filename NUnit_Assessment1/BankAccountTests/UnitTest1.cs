using NUnit.Framework;
using BankAccountApp;
using System;

namespace BankAccountTests
{
    [TestFixture]
    public class BankAccountTests
    {
        private const decimal InitialBalance = 1000m;
        private const decimal SmallBalance = 500m;
        private const decimal DepositAmount = 500m;
        private const decimal WithdrawAmount = 400m;
        private const decimal NegativeAmount = -200m;
        private const decimal ExcessiveWithdrawAmount = 800m;

        [Test]
        public void Deposit_WithValidAmount_ShouldIncreaseBalance()
        {
            // Arrange
            var bankAccount = new Program(InitialBalance);
            var expectedBalance = InitialBalance + DepositAmount;

            // Act
            bankAccount.Deposit(DepositAmount);

            // Assert
            Assert.That(bankAccount.Balance, Is.EqualTo(expectedBalance));
        }

        [Test]
        public void Deposit_WithNegativeAmount_ShouldThrowException()
        {
            // Arrange
            var bankAccount = new Program(InitialBalance);
            var expectedErrorMessage = "Deposit amount cannot be negative";

            // Act & Assert
            var thrownException = Assert.Throws<Exception>(() => bankAccount.Deposit(NegativeAmount));
            Assert.That(thrownException.Message, Is.EqualTo(expectedErrorMessage));
        }

        [Test]
        public void Withdraw_WithValidAmount_ShouldDecreaseBalance()
        {
            // Arrange
            var bankAccount = new Program(InitialBalance);
            var expectedBalance = InitialBalance - WithdrawAmount;

            // Act
            bankAccount.Withdraw(WithdrawAmount);

            // Assert
            Assert.That(bankAccount.Balance, Is.EqualTo(expectedBalance));
        }

        [Test]
        public void Withdraw_WithInsufficientFunds_ShouldThrowException()
        {
            // Arrange
            var bankAccount = new Program(SmallBalance);
            var expectedErrorMessage = "Insufficient funds.";

            // Act & Assert
            var thrownException = Assert.Throws<Exception>(() => bankAccount.Withdraw(ExcessiveWithdrawAmount));
            Assert.That(thrownException.Message, Is.EqualTo(expectedErrorMessage));
        }
    }
}
