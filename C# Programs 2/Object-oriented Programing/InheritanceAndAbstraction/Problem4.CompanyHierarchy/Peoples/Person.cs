using System;

namespace Problem4.CompanyHierarchy
{
    class Person : IPerson
    {
        private int id;
        private string firstName;
        private string lastName;

        public Person(int id, string firstName, string lastName)
        {
            this.ID = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int ID
        {
            get { return this.id; }

            set
            {
                if (value <= 9999 || value > 99999)
                {
                    throw new ArgumentException("The ID should be valid 5 digits number.");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get { return this.firstName; }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("First name cannot be less than 2 chars long!");
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
                    throw new ArgumentException("Last name cannot be less than 2 chars long!");
                }

                this.lastName = value;
            }
        }
    }
}