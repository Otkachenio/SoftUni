using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace Sort3RealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            decimal a, b, c;
            decimal smallest, bigger, biggest;
            smallest = 0;
            bigger = 0;
            biggest = 0;
            Console.Write("Enter your first number a: ");
            bool checkA = decimal.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter your second number b: ");
            bool checkB = decimal.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter your third number c: ");
            bool checkC = decimal.TryParse(Console.ReadLine(), out c);
            if (checkA && checkB && checkC)
            {
                if (a>b)
                {
                    if (b>=c)
                    {
                        smallest = c;
                        bigger = b;
                        biggest = a;
                    }
                    else if (c>=a)
                    {
                        smallest = b;
                        bigger = a;
                        biggest = c;
                    }
                    else if(c>=b)
                    {
                        smallest = b;
                        bigger = c;
                        biggest = a;
                    }
                }
                if (b>a)
                {
                    if (a>=c)
                    {
                        smallest = c;
                        bigger = a;
                        biggest = b;
                    }
                    else if (c>=b)
                    {
                        smallest = a;
                        bigger = b;
                        biggest = c;
                    }
                    else if (c>=a)
                    {
                        smallest = a;
                        bigger = c;
                        biggest = b;
                    }
                }
                else if (a==b)
                {
                    if (c>b)
                    {
                        smallest = b;
                        bigger = a;
                        biggest = c;
                    }
                    else
                    {
                        smallest = c;
                        bigger = a;
                        biggest = b;
                    }
                }

            Console.WriteLine("The descending order is: {0}; {1}; {2}", biggest, bigger, smallest);
            }
            else
            {
                Console.WriteLine("Not a valid entry, use decimal numbers only!");
            }
        }
    }
}
