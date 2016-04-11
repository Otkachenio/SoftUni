namespace Problem2.BankOfKurtovoKonare.BankAccounts
{
    using System;
    using Problem2.BankOfKurtovoKonare.Contracts;
    using Problem2.BankOfKurtovoKonare.Customers;

    class DepositAccount : BankAccount, IDeposit, IWithdraw
    {
        public DepositAccount(string firstName, string lastName, CustomerType type,
            decimal balance, decimal interestRate) : base(
                firstName, lastName, type, balance, interestRate) { }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }

        public override decimal CalculateInterest(int periodInMonths)
        {
            if (Balance > 0 && Balance < 1000)
            {
                InterestRate = 0;
            }
            else
            {
                InterestRate = base.CalculateInterest(periodInMonths);
            }
            
            return InterestRate;
        }

        public override string ToString()
        {
            string result = string.Format("{0} {1} - Balance: {2}$, Interest rate {3}%",
                FirstName, LastName, Balance, InterestRate);

            return result;
        }
    }
}