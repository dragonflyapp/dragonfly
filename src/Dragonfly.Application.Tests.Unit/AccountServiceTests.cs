using Dragonfly.Application.Models;
using Dragonfly.Application.Repositories;
using Dragonfly.Application.Services;
using NSubstitute;
using FluentAssertions;

namespace Dragonfly.Application.Tests.Unit;

/// <summary>
/// CASE:
/// - Create Account
/// DO:
/// - Return true
/// - Log messages
/// - Log exceptions
/// WHEN:
/// - Request is valid
/// - Account created
/// </summary>
public class AccountServiceTests
{
    private readonly AccountService _sut;
    private IAccountRepository _accountRepository = Substitute.For<IAccountRepository>();
    
    public AccountServiceTests()
    {
        _sut = new AccountService(_accountRepository);
    }
    
    [Fact]
    public async void CreateAsync_ShouldReturnTrue_WhenRequestIsValid()
    {
        // Arrange
        Account account = new Account
        {
            Id = new Guid(),
            Name = "TestAccount"
        };

        _accountRepository.CreateAsync(account).Returns(true);
        
        // Act
        var result = await _sut.CreateAsync(account);
        
        // Assert
        result.Should().BeTrue();
    }
}