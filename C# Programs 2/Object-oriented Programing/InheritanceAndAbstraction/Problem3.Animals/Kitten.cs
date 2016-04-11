using System;

namespace Problem3.Animals
{
    class Kitten : Cat, ISound
    {
        private string gender = "female";

        public Kitten(string name, int age, string color
                                        ) : base(name, age, color) { }

        public void ProduceSound()
        {
            Console.WriteLine("Mew mew miu miu");
        }

        public override string ToString()
        {
            string result = String.Format("Kitten {0} is {1} years old {2} cat with {3} fur",
                Name, Age, this.gender, Color);

            return result;
        }
    }
}
