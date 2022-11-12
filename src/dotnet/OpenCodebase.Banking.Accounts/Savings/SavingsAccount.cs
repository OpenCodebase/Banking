namespace OpenCodebase.Banking.Accounts.Savings
{
    public class SavingsAccount<TUserIdentity> : AccountBase<TUserIdentity>
    {
        public SavingsAccount(
            TUserIdentity accountHolderId
        ) : base()
        {
            base.AccountHolderId = accountHolderId;
        }

        public void Deposit(decimal amountToDeposit)
        {
            this.ValidateDeposit(amountToDeposit);

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