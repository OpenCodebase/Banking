using OpenCodebase.Banking.Accounts.Savings;

namespace OpenCodebase.Banking.Tests.Accounts
{
    public class CreateSavingsAccountTests
    {
        [Fact]
        public async Task GivenAUserId_CanCreateANewSavingsAccount()
        {
            // Arrange
            var userId = "Test123";

            // Act
            // Creates a SavingsAccount with a string type Identifier
            var newSavingsAccount = new SavingsAccount<string>(accountHolderId: userId);

            // Assert
            // Assert account object was instantiated
            Assert.NotNull(newSavingsAccount);
            // Assert the account holder ID was correctly set
            Assert.Same(userId, newSavingsAccount.AccountHolderId);
            // Assert the balance was initialised as zero.
            Assert.Equal(0.00M, newSavingsAccount.Balance);
        }
    }
}