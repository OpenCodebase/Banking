using OpenCodebase.Banking.Accounts;
using OpenCodebase.Banking.Accounts.Savings;

namespace OpenCodebase.Banking.Tests.Accounts
{
    public class DepositIntoSavingsAccountTests
    {
        /// <summary>
        /// This tests the happy path, where the account is in a state
        /// which permits deposit, and the deposit amount is positive.
        /// </summary>
        [Fact]
        public void GivenAPositiveDepositValue_WhenAnAccountIsDepositable_ThenTheDepositIsSuccessfulAndTheBalanceIsUpdated()
        {
            // Arrange
            var savingsAccount = SavingsAccount<string>.New(accountHolderId: "Test123");

            // Act
            savingsAccount.Deposit(100.00M);

            // Assert
            Assert.Equal(100.00M, savingsAccount.Balance);
        }

        /// <summary>
        /// This ensures the Deposit() method is not used for reducing the 
        /// balance of the account. Other methods should be used for this 
        /// scenario, not the Deposit() method.
        /// </summary>
        [Fact]
        public void GivenANegativeDepositValue_WhenAnAccountIsDepositable_ThenAnAccountStateExceptionIsThrownAndTheBalanceIsNotUpdated()
        {
            // Arrange
            var savingsAccount = SavingsAccount<string>.New(accountHolderId: "Test123");

            // Act
            Assert.Throws<DepositException<string>>(() => savingsAccount.Deposit(-100.00M));


            // Assert
            Assert.Equal(0M, savingsAccount.Balance);
        }
    }
}