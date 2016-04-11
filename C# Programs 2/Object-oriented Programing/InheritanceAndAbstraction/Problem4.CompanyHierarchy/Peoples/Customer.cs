using System;

namespace Problem4.CompanyHierarchy
{
    class Customer : Person
    {
        private decimal spendedMoney;

        public Customer(int id, string firstName, string lastName, decimal spendedMoney
            ) : base (id, firstName, lastName)
        {
            this.SpendedMoney = spendedMoney;
        }

        public decimal SpendedMoney
        {
            get { return this.spendedMoney; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Spended money cannot be negative number!");
                }

                this.spendedMoney = value;
            }
        }
    }
}