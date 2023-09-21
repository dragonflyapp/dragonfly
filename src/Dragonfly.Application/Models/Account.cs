namespace Dragonfly.Application.Models;

public class Account
{
    public required Guid Id { get; init; }
    public required string Name { get; set; }
    public required string Currency { get; set; }
    public List<Transaction> Transactions { get; init; } = new();

    public decimal CalculateBalance()
    {
        return Transactions.Sum(x => x.Amount);
    }
}