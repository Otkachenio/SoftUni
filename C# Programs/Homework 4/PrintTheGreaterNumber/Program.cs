using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintTheGreaterNumber
{
    class Program
    {
        static void Main()
        {
            //Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.
            double a, b;
            Console.Write("Please, enter your first number: ");
            bool checkA = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Please, enter your second number: ");
            bool checkB = double.TryParse(Console.ReadLine(), out b);
            if (checkA && checkB)
            {
                Console.Write("The greater number is: ");
                Console.WriteLine(Math.Max(a, b));
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the numbers are not double!");
            }
        }
    }
}
