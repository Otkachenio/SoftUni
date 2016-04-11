using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace ShowTheSignOfTheProduct
{
    class Program
    {
        public static bool str { get; private set; }

        static void Main(string[] args)
        {
            //Write a program that shows the sign (+ or -) of the product of three real numbers...
            //...without calculating it. Use a sequence of if statements.
            Thread.CurrentThread.CurrentUICulture = CultureInfo.InvariantCulture;
            double a, b, c;
            byte positiveNumbers = 0;
            Console.Write("Please, enter your first number a: ");
            bool checkA = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Please, enter your second number b: ");
            bool checkB = double.TryParse(Console.ReadLine(), out b);
            Console.Write("Please, enter your third number c: ");
            bool checkC = double.TryParse(Console.ReadLine(), out c);
            if (checkA && checkB && checkC)
            {
                if (Math.Sign(a) == 1)
                {
                    positiveNumbers = (byte)(positiveNumbers + 1);
                }
                if (Math.Sign(b) == 1)
                {
                    positiveNumbers = (byte)(positiveNumbers + 1);
                }

                if (Math.Sign(c) == 1)
                {
                    positiveNumbers = (byte)(positiveNumbers + 1);
                }
                if (positiveNumbers % 2 == 0)
                {
                    Console.WriteLine("The sign of the product is (-)");
                }
                else
                {
                    Console.WriteLine("The sign of the product is (+)");
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry, use double numbers only!");
            }
        }
    }
}
