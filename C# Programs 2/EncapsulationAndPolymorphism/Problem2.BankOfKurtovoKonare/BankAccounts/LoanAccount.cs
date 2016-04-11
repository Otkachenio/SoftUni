namespace Problem2.BankOfKurtovoKonare.BankAccounts
{
    using System;
    using Customers;
    using Problem2.BankOfKurtovoKonare.Contracts;
       
    class LoanAccount : BankAccount, IDeposit
    {
        public LoanAccount(string firstName, string lastName, CustomerType type,
            decimal balance, decimal interestRate) : base(
                firstName, lastName, type, balance, interestRate) { }

        public void Deposit(decimal amount)
        {
            if (Balance + amount > 0)
            {
                Console.WriteLine("Your mortgage is: {0}", (this.Balance * -1));
                throw new ArgumentException(
                    "You cannot deposit more money than the loan!");
            }
            this.Balance += amount;
        }

        public override decimal CalculateInterest(int periodInMonths)
        {
            int monthsWithoutInterest = 3;
            if (Type == CustomerType.companies)
            {
                monthsWithoutInterest = 2;
            }

            return base.CalculateInterest(periodInMonths - monthsWithoutInterest);
        }

        public override string ToString()
        {
            string result = string.Format("{0} {1} - Balance: {2}$, Interest rate {3}%",
                FirstName, LastName, Balance, InterestRate);

            return result;
        }
    }
}