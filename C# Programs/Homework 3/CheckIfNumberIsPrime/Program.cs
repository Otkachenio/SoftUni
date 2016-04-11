

















using System;

namespace CheckIfNumberIsPrime
{
    class Program
    {
        static void Main()
        {
            bool isPrime = true;
            int number;
            Console.Write("Enter a number: ");
            bool ItsANumber = int.TryParse(Console.ReadLine(), out number);
            if (ItsANumber)
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                    }
                }
                Console.WriteLine("Is this a prime number?: {0}", isPrime);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}



