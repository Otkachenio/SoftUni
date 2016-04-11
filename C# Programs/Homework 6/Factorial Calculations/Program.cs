using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Calculations
{
    class Program
    {
        static void Main()
        {
            int n, k;
            BigInteger nF = 1, kF = 1, nkF, p, pF = 1, value;
            Console.Write("Please, enter your first factorial N: ");
            bool checkN = int.TryParse(Console.ReadLine(), out n);
            Console.Write("Please, enter your second factorial K: ");
            bool checkK = int.TryParse(Console.ReadLine(), out k);
            if (checkN && checkK && n > 1 && k > n)
            {
                for (int i = 1; i <= n; i++)
                {
                    nF = nF * i;
                }
                for (int i2 = 1; i2 <= k; i2++)
                {
                    kF = kF * i2;
                }
                Console.WriteLine("N! = " + nF);
                Console.WriteLine("K! = " + kF);
                nkF = nF * kF;
                Console.WriteLine("N!*K! = " + nkF);
                p = (k-n);
                for (int i3 = 1; i3 <= p; i3++)
                {
                    pF = pF * i3;
                }
                Console.WriteLine("(K-N)! = " + pF);
                value = nkF / pF;
                Console.WriteLine("N!*K! /(K-N)! = " + value);

            }
            else
            {
                Console.WriteLine("ERROR: Not a valid entry, enter only positive integers and folow the rule (1<N<K)");
            }
        }
    }
}
