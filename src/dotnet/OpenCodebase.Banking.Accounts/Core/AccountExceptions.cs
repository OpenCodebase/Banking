namespace OpenCodebase.Banking.Accounts
{
    public class DepositException<TAccountHolderIdentity> : Exception
    {
        public DepositException(AccountBase<TAccountHolderIdentity> account, string message) : base(message){}
    }
}