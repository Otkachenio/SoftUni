namespace Problem2.BankOfKurtovoKonare.Customers
{
    using System;

    public abstract class Customer
    {
        private string firstName;
        private string lastName;
        private CustomerType type;

        public Customer(string firstName, string lastName, CustomerType type)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Type = type;
        }

        public string FirstName
        {
            get { return this.firstName; }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("First name must be at least 2 chars long!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Last name must be at least 2 chars long!");
                }

                this.lastName = value;
            }
        }

        public CustomerType Type
        {
            get { return this.type; }

            set
            {
                this.type = value;
            }
        }
    }
}