using System;

namespace Problem3.Animals
{
    class Cat : Animal
    {
        public string color;

        public Cat(string name, int age, string color, string gender = null
                                            ) : base (name, age)
        {
            this.Color = color;
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
