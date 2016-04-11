using System;

namespace Problem1_Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, string email) : this(name, age)
        {
            this.Email = email;
        }

        
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ERROR: Name cannot be empty!");
                }
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name should be at least 2 chars long!");
                }
                if (value.Length > 50)
                {
                    throw new ArgumentException("Name cannot be more than 50 chars length!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value <= 0 || value > 120)
                {
                    throw new ArgumentException("Age must be valid number between 1 and 120");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (value != null && !value.Contains("@"))
                {
                    throw new ArgumentException("Email must contain @!");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            string forPrint = String.Format("Name: {0}, Age: {1}", this.name, this.age);

            if (!String.IsNullOrEmpty(email))
            {
                forPrint += String.Format(", Email: {0}", this.email);
            }

            return forPrint;
        }
    }
}