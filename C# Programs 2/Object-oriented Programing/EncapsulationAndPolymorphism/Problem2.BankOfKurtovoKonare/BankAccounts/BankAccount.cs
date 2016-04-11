namespace Problem2.BankOfKurtovoKonare.BankAccounts
{
    using Problem2.BankOfKurtovoKonare.Customers;
    using System;

    public abstract class BankAccount : Customer
    {
        private decimal balance;
        private decimal interestRate;

        public BankAccount(string firstName, string lastName, CustomerType type,
            decimal balance, decimal interestRate) : base (firstName, lastName, type)
        {
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal Balance
        {
            get { return this.balance; }

            protected set
            {
                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Interest rate cannot be negative number!");
                }

                this.interestRate = value;
            }
        }

        public virtual decimal CalculateInterest(int periodInMonths)
        {
            decimal interest = this.Balance * (1 + (this.InterestRate * periodInMonths));

            return interest;
        }
    }
}