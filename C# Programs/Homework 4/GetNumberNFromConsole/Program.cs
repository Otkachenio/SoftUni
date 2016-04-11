using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace GetNumberNFromConsole
{
    class Program
    {
        static void Main()
        {
            //Write a program that gets a number n and after that gets more n numbers and calculates and prints their sum.
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            byte numbersOfN = 0;
            double n;
            double b = 0;
            bool isValidEntry = true;
            Console.Write("Please, enter how many numbers you want to sum: ");
            bool checkNumbersOfN = byte.TryParse(Console.ReadLine(), out numbersOfN);
            if (checkNumbersOfN && numbersOfN >= 2)
            {
                for (int number = 1; number <= numbersOfN; number++)
                {
                    Console.Write("Please, enter your number: ");
                    bool checkN = double.TryParse(Console.ReadLine(), out n);
                    if (checkN)
                    {
                        b = b + n;
                    }
                    else
                    {
                        Console.WriteLine("Not a number entry!");
                        isValidEntry = false;
                        break;
                    }
                }
                if (isValidEntry)
                {
                    Console.WriteLine("The sum of your numbers is: " + b);
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry, the number of numbers should be byte and bigger than 2");
            }
        }
    }
}
