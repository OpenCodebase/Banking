namespace OpenCodebase.Banking.Accounts
{
    /// <summary>
    /// Base class for banking accounts
    /// </summary>
    /// <typeparam name="TUserIdentity">The type of the UserId. This allows the Accounts types to work in a variety of codebases.</typeparam>
    public abstract class AccountBase<TUserIdentity>
    {
        /// <summary>
        /// The system-level identifier of the account holder (e.g. primary key of the user record)
        /// </summary>
        /// <value>The system-level identifier of the account holder</value>
        public TUserIdentity AccountHolderId { get; protected set; }

        /// <summary>
        /// The balance of the account. Negative values indicate accounts in debit whereas positive balances indicate accounts in credit.
        /// </summary>
        /// <value>The balance on the account.</value>
        public decimal Balance { get; protected set; } = 0.00M;
    }
}