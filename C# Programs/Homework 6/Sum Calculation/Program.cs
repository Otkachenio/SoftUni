using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Sum_Calculation
{
    class Program
    {
        static void Main()
        {
            //Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/ X + 2!/ X2 + … +N!/ XN
            decimal x, n;
            decimal nF = 1;
            decimal sumS = 1;
            Console.Write("Please, enter value for N: ");
            bool checkN = decimal.TryParse(Console.ReadLine(), out n);
            Console.Write("Please, enter value for X: ");
            bool checkX = decimal.TryParse(Console.ReadLine(), out x);

            if (checkN && checkX && x>0 && n>0)
            {
                for (int i = 1; i <= n; i++)
                {
                    nF = nF * i;
                    sumS = (sumS + nF) / x;
                }
                Console.WriteLine(nF);
                Console.WriteLine(sumS);
            }
            else
            {
                Console.WriteLine("ERROR: Invalid Enrty, enter only positive unsigned integers!");
            }
        }
    }
}
