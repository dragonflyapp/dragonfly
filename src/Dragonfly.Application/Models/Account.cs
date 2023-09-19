namespace Dragonfly.Application.Models;

public class Account
{
    public required Guid Id { get; init; }
    public string Name { get; set; }
}