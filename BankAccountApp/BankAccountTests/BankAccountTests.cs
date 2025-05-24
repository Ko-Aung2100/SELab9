﻿using Xunit;
using BankAccountApp;
using System;
namespace BankAccountTests
{
    public class BankAccountTests
    {
        [Theory]
        [InlineData("John Doe", 1000, 200, 800)]
        [InlineData("Jane Smith", 500, 100, 400)]
        [InlineData("Alice Johnson", 300, 50, 250)]
        public void Debit_ValidAmount_UpdatesBalance(string customerName, decimal
        initialBalance, decimal debitAmount, decimal expectedBalance)
        {
            // Arrange
            var account = new BankAccount(customerName, initialBalance);
            // Act
            account.Debit(debitAmount);
            // Assert
            Assert.Equal(expectedBalance, account.Balance);
        }
        [Theory]
        [InlineData("Bob Brown", 100, 150)]
        public void Debit_InsufficientFunds_ThrowsException(string customerName,
        decimal initialBalance, decimal debitAmount)
        {
            // Arrange
            var account = new BankAccount(customerName, initialBalance);
            // Act & Assert
            Assert.Throws<InvalidOperationException>(() =>

            account.Debit(debitAmount));
        }
        [Theory]
        [InlineData("John Doe", 1000, 200, 1200)]
        [InlineData("Jane Smith", 500, 100, 600)]
        [InlineData("Alice Johnson", 300, 50, 350)]
        public void Credit_ValidAmount_UpdatesBalance(string customerName, decimal
        initialBalance, decimal creditAmount, decimal expectedBalance)
        {
            // Arrange
            var account = new BankAccount(customerName, initialBalance);
            // Act
            account.Credit(creditAmount);
            // Assert
            Assert.Equal(expectedBalance, account.Balance);
        }
        [Theory]
        [InlineData("John Doe", 1000, 200, 800)]
        [InlineData("Jane Smith", 500, 100, 400)]
        [InlineData("Alice Johnson", 300, 50, 250)]
        public void Withdraw_ValidAmount_UpdatesBalance(string customerName, decimal
        initialBalance, decimal withdrawAmount, decimal expectedBalance)
        {
            // Arrange
            var account = new BankAccount(customerName, initialBalance);
            // Act
            account.Withdraw(withdrawAmount);
            // Assert
            Assert.Equal(expectedBalance, account.Balance);
        }
    }
}