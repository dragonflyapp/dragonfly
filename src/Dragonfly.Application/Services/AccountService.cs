using Dragonfly.Application.Models;
using Dragonfly.Application.Repositories;

namespace Dragonfly.Application.Services;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    
    public AccountService(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;    
    }
    
    public async Task<bool> CreateAsync(Account account)
    {
        return await Task.FromResult(true);
    }
}