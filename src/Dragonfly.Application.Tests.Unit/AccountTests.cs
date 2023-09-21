using Dragonfly.Application.Models;
using FluentAssertions;

namespace Dragonfly.Application.Tests.Unit;

/// <summary>
/// 1. Should return correct balance when:
///     - Account and Transaction Same currency
///     - Account and Transaction Different currency
///     - Account and Transactions all different currency
///     - No transactions
///     
/// Implement double entry
/// Different account types
/// </summary>
public class AccountTests
{
    [Fact]
    public void CalculateBalance_ShouldReturnCorrectBalance_WhenAccountAndTransactionSameCurrency()
    {
        // Arrange
        Transaction transaction1 = new Transaction
        {
            Id = Guid.NewGuid(),
            Date = DateOnly.FromDateTime(DateTime.Now),
            Description = "Test",
            Unit = 10,
            Price = 0.99m,
            Currency = "USD"
        };
        
        Transaction transaction2 = new Transaction
        {
            Id = Guid.NewGuid(),
            Date = DateOnly.FromDateTime(DateTime.Now),
            Description = "Test",
            Unit = 20,
            Price = 0.99m,
            Currency = "USD"
        };

        Account account = new Account
        {
            Id = Guid.NewGuid(),
            Name = "TestAccount",
            Currency = "USD",
            Transactions = new List<Transaction> { transaction1, transaction2 }
        };

        // Act
        decimal balance = account.CalculateBalance();
        
        // Assert
        balance.Should().Be(transaction1.Amount + transaction2.Amount);
    }
}