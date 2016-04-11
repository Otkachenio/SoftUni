using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.CompareTwoInteger
{
    class Program
    {
        static void Main()
        {
            int a, b, g;
            Console.Write("Please, enter your first number a: ");
            bool checkF = int.TryParse(Console.ReadLine(), out a);
            Console.Write("Please, enter your second number b: ");
            bool checkS = int.TryParse(Console.ReadLine(), out b);
            if (checkF && checkS)
            {
                if (a > b)
                {
                    g = b;
                    b = a;
                    a = g;
                }
                Console.WriteLine("a = " + a);
                Console.WriteLine("b = " + b);
            }
            else
            {
                Console.WriteLine("Not an integer number");
            }
        }
    }
}