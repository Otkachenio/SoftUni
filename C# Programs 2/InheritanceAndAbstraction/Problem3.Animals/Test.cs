using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3.Animals
{
    class Test
    {
        static void Main(string[] args)
        {
            List<Animal> animalsList = new List<Animal>();

            animalsList.Add(new Dog("Sharo", 10, "male", "Kavkazec"));
            animalsList.Add(new Dog("Pesho", 3, "male", "Street excellent"));
            animalsList.Add(new Kitten("Maca", 8, "black"));
            animalsList.Add(new Tomcat("Kotyo", 5, "colorful"));
            animalsList.Add(new Frog("Penka", 70, "female", "talker"));
            animalsList.Add(new Frog("Ginka", 72, "female", "talker"));
            animalsList.Add(new Frog("Gosho", 28, "male", "Java"));

            int catsAverageAge = (int)animalsList.Where(x => x is Cat).Average(x => x.Age);
            Console.WriteLine("Cats average age: {0}", catsAverageAge);

            int dogsAverageAge = (int)animalsList.Where(x => x is Dog).Average(x => x.Age);
            Console.WriteLine("Dogs average age: {0}", dogsAverageAge);

            int frogsAverageAge = (int)animalsList.Where(x => x is Frog).Average(x => x.Age);
            Console.WriteLine("Frogs average age: {0}", frogsAverageAge);
        }
    }
}