using System;

namespace Problem3.Animals
{
    public class Dog : Animal, ISound
    {
        private string breed;

        public Dog(string name, int age, string gender, string breed) : base (name, age, gender)
        {
            this.Breed = breed;
        }

        public void ProduceSound()
        {
            Console.WriteLine("Waf waf baf baf");
        }

        public string Breed
        {
            get { return this.breed; }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Breed cannot be empty!");
                }

                this.breed = value;
            }
        }
    }
}