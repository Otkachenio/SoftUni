using System;

namespace Problem3.Animals
{
    class Tomcat : Cat, ISound
    {
        private string gender = "male";

        public Tomcat(string name, int age, string color) : base(name, age, color) { }

        public void ProduceSound()
        {
            Console.WriteLine("Maw maw miau miau");
        }

        public override string ToString()
        {
            string result = String.Format("Tomcat {0} is {1} years old {2} cat with {3} fur", 
                Name, Age, this.gender, Color);

            return result;
        }      
    }
}
