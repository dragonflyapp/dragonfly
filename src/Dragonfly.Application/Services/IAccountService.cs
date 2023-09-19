using Dragonfly.Application.Models;

namespace Dragonfly.Application.Services;

public interface IAccountService
{
    Task<bool> CreateAsync(Account account);
}