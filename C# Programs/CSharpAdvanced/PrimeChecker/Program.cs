using System;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long number;
            Console.Write("Please, Enter your number: ");
            bool checkNumber = long.TryParse(Console.ReadLine(), out number);

            if (checkNumber && number >= 0)
            {
                if (isPrime(number))
                {
                    Console.WriteLine($"{number} is prime");
                }
                else
                {
                    Console.WriteLine($"{number} is not prime");
                }
            }
            else
            {
                Console.WriteLine("ERROR: Not a valid entry - OPositive long numbers only!!!");
            }
        }

        public static bool isPrime(long number)
        {
            long boundary = (long)Math.Floor(Math.Sqrt(number));

            if (number == 0) return false;
            if (number == 1) return false;
            if (number == 2) return true;

            for (long i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}

