namespace OpenCodebase.Banking.Accounts.Savings
{
    public class SavingsAccount<TUserIdentity> : AccountBase<TUserIdentity>
    {

        /// <summary>
        /// For serialisers and factory methods only
        /// </summary>
        private SavingsAccount() {}

        public static SavingsAccount<TUserIdentity> New(
            TUserIdentity accountHolderId
        )
        {
            return new SavingsAccount<TUserIdentity>
            {
                AccountHolderId = accountHolderId
            };
        }

        public void Deposit(decimal amountToDeposit)
        {
            this.ValidateDeposit(amountToDeposit);

            // TODO: Add events where enabled
            this.Balance += amountToDeposit;
        }

        private void ValidateDeposit(decimal amountToDeposit)
        {
            // TODO: Add limits and restrictions
            if(amountToDeposit < 0)
            {
                throw new DepositException<TUserIdentity>(this, "Desposit amount must be a positive amount. To adjust balances use Adjust(), to withdraw use Withdraw().");
            }

            // Is valid.
        }
    }
}