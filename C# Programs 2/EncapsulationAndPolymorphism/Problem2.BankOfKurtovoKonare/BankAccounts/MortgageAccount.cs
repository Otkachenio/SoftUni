namespace Problem2.BankOfKurtovoKonare.BankAccounts
{
    using System;
    using Problem2.BankOfKurtovoKonare.Contracts;
    using Problem2.BankOfKurtovoKonare.Customers;

    class MortgageAccount : BankAccount, IDeposit
    {
        public MortgageAccount(string firstName, string lastName, CustomerType type,
            decimal balance, decimal interestRate) : base (
                firstName, lastName, type, balance, interestRate) { }

        public void Deposit(decimal amount)
        {
            if (Balance + amount > 0)
            {
                Console.WriteLine("Your loan is: {0}", (this.Balance * -1));
                throw new ArgumentException(
                    "You cannot deposit more money than the mortgage!");
            }
            this.Balance += amount;
        }

        public override decimal CalculateInterest(int periodInMonths)
        {
            decimal interest = 0;
            int companiesDiscount = 12;
            int individualsDiscount = 0;

            if (Type == CustomerType.companies)
            {
                int halfInterest = Math.Min(periodInMonths, companiesDiscount);
                interest = this.Balance * (1 + this.InterestRate * periodInMonths) / 2;
                if (periodInMonths <= 12)
                {
                    return interest;
                }

                periodInMonths += companiesDiscount;
            }
            else
            {
                int NoInterest = Math.Min(periodInMonths, individualsDiscount);
                interest = 0;
                if (periodInMonths <= 6)
                {
                    return interest;
                }

                periodInMonths -= individualsDiscount;
            }

            interest += base.CalculateInterest(periodInMonths);

            return interest;
        }

        public override string ToString()
        {
            string result = string.Format("{0} {1} - Balance: {2}$, Interest rate {3}%",
                FirstName, LastName, Balance, InterestRate);

            return result;
        }
    }
}