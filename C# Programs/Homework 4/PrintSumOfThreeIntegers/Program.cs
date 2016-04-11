using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSumOfThreeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 integer numbers from the console and prints their sum.
            int a, b, c;
            Console.Write("Please, enter the first number a: ");
            bool checkA = int.TryParse(Console.ReadLine(), out a);
            Console.Write("Please, enter the second number b: ");
            bool checkB = int.TryParse(Console.ReadLine(), out b);
            Console.Write("Please, enter the third number c: ");
            bool checkC = int.TryParse(Console.ReadLine(), out c);
            if (checkA && checkB && checkC)
            {
                Console.WriteLine("The sum of the three numbers is: {0}", (a + b + c));
            }
            else
            {
                Console.WriteLine("Not a valid Entry!");
            }
        }
    }
}
