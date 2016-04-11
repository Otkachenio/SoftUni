using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter your search range: ");
            int n = int.Parse(Console.ReadLine());
            bool[] check = new bool[n];

            for (int i = 0; i < n; i++)
            {
                check[i] = true;
            }
            for (int j = 2; j < n; j++)
            {
                if (check[j])
                { 
                    for (long p = 2; (p * j) < n; p++)
                    {
                        check[p * j] = false;
                    }
                }
            }
            for (int a = 2; a < n; a++)
            {
                if(check[a])
                {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
