using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheBiggestNumberOfThree
{
    class Program
    {
        static void Main()
        {
            int a, b, c;
            int bn = 0;
            Console.Write("Please, enter first your number a: ");
            bool checkA = int.TryParse(Console.ReadLine(), out a);
            Console.Write("Please, enter second your number b: ");
            bool checkB = int.TryParse(Console.ReadLine(), out b);
            Console.Write("Please, enter third your number c: ");
            bool checkC = int.TryParse(Console.ReadLine(), out c);

            if (checkA && checkB && checkC)
            {
                if (a>b)
                {
                    if (a>c)
                    {
                        bn = a;
                    }
                }
                if (b>a)
                {
                    if (b>c)
                    {
                        bn = b;
                    }
                }
                if (c>a)
                {
                    if (c>b)
                    {
                        bn = c;
                    }
                    
                }
                if (a == b)
                {
                    bn = a;
                }
                if (a == c)
                {
                    bn = c;
                }
                if (c == b)
                {
                    bn = c;
                }

                Console.WriteLine("The biggest number is: " + bn);
            }
            
            else
            {
                Console.WriteLine("Not a valid entry, use integer numbers only!");
            }
        }
    }
}
