using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Devision_Of_Factorials
{
    class Program
    {
        static void Main()
        {
            int n, k;
            BigInteger nF = 1, kF = 1, nk = 1;
            Console.Write("Please, enter your first factorial N: ");
            bool checkN = int.TryParse(Console.ReadLine(), out n);
            Console.Write("Please, enter your second factorial K: ");
            bool checkK = int.TryParse(Console.ReadLine(), out k);
            if (checkN && checkK && n>1 && k > n)
            {
                for (int i = 1; i <= n; i++)
                {
                    nF = nF * i;
                }
                Console.WriteLine("N! is: " + nF);
                for (int i2 = 1; i2 <= k; i2++)
                {
                    kF = kF * i2; 
                }
                Console.WriteLine("K! is: " + kF);
                nk = kF / nF;
                Console.WriteLine("N!/K! = " + nk);
            }
            else
            {
                Console.WriteLine("ERROR: Enter only positive integer numbers, and folow the rule (1>N>K)");
            }
        }
    }
}
