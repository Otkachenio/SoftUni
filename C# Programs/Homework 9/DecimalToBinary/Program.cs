using System;
using System.Collections.Generic;

namespace DecimalToBinary
{
    class Program
    {
        static void Main()
        {
            int number;
            List<int> binaryList = new List<int>();
            Console.Write("Please, enter your decimal number: ");
            bool checkdNumber = int.TryParse(Console.ReadLine(), out number);

            if (checkdNumber)
            {
                while (number > 0)
                {
                    binaryList.Add(number % 2);
                    number = number / 2;
                }
                binaryList.Reverse();

                Console.Write("Your number in binary is: ");
                foreach (var c in binaryList)
                {
                    Console.Write($"{c} ");
                }
            }
            else
            {
                Console.WriteLine("Invalid entry!");
            }
            Console.ReadLine();
        }
    }
}
