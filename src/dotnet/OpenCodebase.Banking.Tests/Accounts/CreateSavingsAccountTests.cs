using OpenCodebase.Banking.Accounts.Savings;

namespace OpenCodebase.Banking.Tests.Accounts
{
    public class CreateSavingsAccountTests
    {
        /// <summary>
        /// This test verifies the simplest account can be created.
        /// This only needs an account holder identifier and
        /// initialises an account with a zero balance.
        /// </summary>
        [Fact]
        public void GivenAUserId_CanCreateANewSavingsAccount()
        {
            // Arrange
            var userId = "Test123";

            // Act
            // Creates a SavingsAccount with a string type Identifier
            var newSavingsAccount = SavingsAccount<string>.New(accountHolderId: userId);

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