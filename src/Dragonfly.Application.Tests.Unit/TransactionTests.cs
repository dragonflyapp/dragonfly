using Dragonfly.Application.Models;
using FluentAssertions;

namespace Dragonfly.Application.Tests.Unit;

/// <summary>
/// 1. Transaction can be currency or non currency
/// 2. If currency,
/// 1 unit of usd = 100 usd at 2020 = 200 at 2023
/// 1 unit of AAPL = 100 usd at 2020 = 200 at 2023
/// So we have to store the unit, and original price
/// So the model will have unit, original_price, id, description and date
/// </summary>
public class TransactionTests
{
    [Theory]
    [InlineData(1, 10)]
    [InlineData(27, 0.9999)]
    [InlineData(100, 10.67)]
    [InlineData(300, 88.88)]
    [InlineData(0.99, 101.86)]
    [InlineData(12.86, 0.91)]
    public void Amount_ShouldReturnCorrectAmount_GivenQuantityAndUnitPrice(decimal unit, decimal price)
    {
        // Arrange
        Transaction transaction = new Transaction
        {
            Id = Guid.NewGuid(),
            Date = DateOnly.FromDateTime(DateTime.Now),
            Description = "Test",
            Unit = unit,
            Price = price,
            Currency = "USD"
        };
        
        // Act
        
        // Assert
        transaction.Amount.Should().Be(unit * price);
    }
}

