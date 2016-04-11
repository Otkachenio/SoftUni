using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Fibonacci_Sequence
{
    class Program
    {
        static void Main()
        {
            BigInteger n = 0, fsum = 0, a = 0, b = 1;
            Console.Write("Please, enter your number N: ");
            bool checkN = BigInteger.TryParse(Console.ReadLine(), out n);
            if (checkN && n>0)
            {
                for (int i = 0; i < n; i++)
                {
                    BigInteger temp = a;
                    a = b;
                    b = temp + b;
                    fsum = fsum + temp;
                }
                Console.WriteLine("The sum of first {0} numbers of the fibonachi sequence is: {1}", n, fsum);
            }
            else
            {
                Console.WriteLine("ERROR: Not a valid entry, enter only postive numers!");
            }
        }
    }
}
