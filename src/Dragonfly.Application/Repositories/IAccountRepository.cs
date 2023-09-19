using Dragonfly.Application.Models;

namespace Dragonfly.Application.Repositories;

public interface IAccountRepository
{
    Task<bool> CreateAsync(Account account);
}