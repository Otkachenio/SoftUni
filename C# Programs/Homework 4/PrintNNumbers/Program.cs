using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNNumbers
{
    class Program
    {
        static void Main()
        {
            int n;
            Console.Write("Please, enter your number n: ");
            bool checkN = int.TryParse(Console.ReadLine(), out n);
            if (checkN && n>0)
            {
                for (int number = 1; number <= n; number++)
                {
                    Console.WriteLine(number);
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry, please enter integer number bigger than 0");
            }
        }
    }
}
