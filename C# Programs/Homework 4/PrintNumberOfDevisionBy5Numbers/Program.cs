using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNumberOfDevisionBy5Numbers
{
    class Program
    {
        static void Main()
        {
            //Write a program that reads two positive integer numbers and prints how many numbers p exist...
            //...between them such that the reminder of the division by 5 is 0 (inclusive). Example: p(17,25) = 2.
            uint a, b, p;
            p = 0;
            Console.Write("Please, enter the first number a: ");
            bool checkA = uint.TryParse(Console.ReadLine(), out a);
            Console.Write("Please, enter the second number b: ");
            bool checkB = uint.TryParse(Console.ReadLine(), out b);
            Console.Write("p(" + a + "," + "" + b + ") = ");
            if (checkA && checkB)
            {
                if (a > b)
                {
                    while (a > b)
                    {
                        if (b % 5 == 0)
                        {
                            p++;
                        }
                        b++;
                    }
                    Console.WriteLine(p);
                }
                else if (a == b)
                {
                    if (b % 5 == 0)
                    {
                        p++;
                    }
                    Console.WriteLine(p);
                }
                else
                {
                    while (b > a)
                    {
                        if (a % 5 == 0)
                        {
                            p++;
                        }
                        a++;
                    }
                    Console.WriteLine(p);
                }
            }
            else
            {
                Console.WriteLine("Not a valid Entry, please enter positive integer numbers next time!");
            }
        }
    }
}
