using System;

namespace Problem3.Animals
{
    class Frog : Animal, ISound
    {
        private string color;

        public Frog(string name, int age, string gender, string color
                                            ) : base (name, age, gender)
        {
            this.Color = color;
        }

        public void ProduceSound()
        {
            Console.WriteLine("Quak quak kva kva");
        }

        public string Color
        {
            get { return this.color; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Color cannot be empty!");
                }

                this.color = value;
            }
        }
    }
}
