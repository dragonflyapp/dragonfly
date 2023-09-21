namespace Dragonfly.Application.Models;

public class Transaction
{
    public required Guid Id { get; init; }
    public required DateOnly Date { get; set; }
    public required string Description { get; set; }
    public required decimal Unit { get; set; }
    public required decimal Price { get; set; }
    
    public required string Currency { get; set; }
    public decimal Amount => Unit * Price;
}