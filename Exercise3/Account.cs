namespace Exercise3
{
    using System.Diagnostics.Contracts;

    public class Account
    {
        public int Balance;
        public int Limit;
        public Account(int balance, int limit)
        {
            Contract.Requires(balance >=0 && limit > 0);
            Contract.Ensures(this.Balance==balance && this.Limit==limit);
            Balance = balance;
            Limit = limit;
        }
        public int Deposit(int amount)
        {
            Contract.Requires(amount > 0);
            Contract.Ensures(Balance == Contract.OldValue(Balance) + amount);
            Balance += amount;
            return Balance;
        }
        public int Withdraw(int amount)
        {
            Contract.Requires(amount > 0);
            Contract.Ensures(
                (Balance == Contract.OldValue(Balance) - amount) &&
                (amount <= Limit && amount <= Contract.OldValue(Balance)));
            Contract.Ensures(Contract.Result<int>() == Balance);
            
            if (amount <= Limit && amount <= Balance)
            {
                Balance -= (amount);
                Contract.Assume(Balance == Contract.OldValue(Balance) - amount);
            }
            return Balance;
        }
    }}
