using OpenCodebase.Banking.Accounts;
using OpenCodebase.Banking.Accounts.Savings;

namespace OpenCodebase.Banking.Tests.Accounts
{
    public class DepositIntoSavingsAccountTests
    {
        [Fact]
        public async Task GivenAPositiveDepositValue_WhenAnAccountIsDepositable_ThenTheDepositIsSuccessfulAndTheBalanceIsUpdated()
        {
            // Arrange
            var savingsAccount = new SavingsAccount<string>(accountHolderId: "Test123");

            // Act
            savingsAccount.Deposit(100.00M);

            // Assert
            Assert.Equal(100.00M, savingsAccount.Balance);
        }

        [Fact]
        public async Task GivenANegativeDepositValue_WhenAnAccountIsDepositable_ThenAnAccountStateExceptionIsThrownAndTheBalanceIsNotUpdated()
        {
            // Arrange
            var savingsAccount = new SavingsAccount<string>(accountHolderId: "Test123");

            // Act
            Assert.Throws<DepositException<string>>(() => savingsAccount.Deposit(-100.00M));


            // Assert
            Assert.Equal(0M, savingsAccount.Balance);
        }
    }
}