using System;

namespace Problem3.Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public Animal(string name, int age, string gender = null)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value <  0)
                {
                    throw new ArgumentException("Age cannot be negative number!");
                }

                this.age = value;
            }
        }

        public string Gender
        {
            get { return this.gender; }

            set
            {
                this.gender = value;
            }
        }
    }
}