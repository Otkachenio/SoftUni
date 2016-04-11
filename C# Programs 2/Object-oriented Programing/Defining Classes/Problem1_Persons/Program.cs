using System;

namespace Problem1_Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person pesho = new Person("Pesho", 20);
            Person sasho = new Person("Sasho", 20, "otkachenio@mail.bg");

            Console.WriteLine(pesho + " --> The NooB");
            Console.WriteLine(sasho + " --> The PrO");
        }
    }
}