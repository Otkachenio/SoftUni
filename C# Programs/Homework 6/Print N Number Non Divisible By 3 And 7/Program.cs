using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_N_Number_Non_Divisible_By_3_And_7
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.Write("Please, enter your number: ");
            bool checkN = int.TryParse(Console.ReadLine(), out n);
            if (checkN && n>=1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i % 21 == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("ERROR: Not a valid entry, enter only positive integer numbers");
            }
        }
    }
}
