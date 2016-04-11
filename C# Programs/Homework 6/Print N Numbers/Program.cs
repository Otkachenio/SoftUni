using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_N_Numbers
{
    class Program
    {
        static void Main()
        {
            int n, i;
            i = 1;
            Console.Write("Please, enter your number: ");
            bool checkN = int.TryParse(Console.ReadLine(), out n);
            if (checkN && n >= 1)
            {
                while (i <= n)
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
            else
            {
                Console.WriteLine("ERROR: Not a valid entry, enter only integer numbers bigget than 1");
            }
        }
    }
}
