using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Find_Zeroes_At_The_End_Of_The_Factorial
{
    class Program
    {
        static void Main()
        {
            /*Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
            N = 10 => N! = 3628800 => 2
            N = 20 => N! = 2432902008176640000 => 4
            Does your program work for N = 50 000?
            Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why! */
            BigInteger nF = 1;
            int n, p = 0;
            Console.Write("Please, enter N!: ");
            bool checkN = int.TryParse(Console.ReadLine(), out n);

            if (checkN && n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    nF = nF * i;
                }
                Console.WriteLine(nF);
                while (nF % 5 == 0)
                {
                    p++;
                    nF = nF / 10;
                }
                Console.WriteLine("Number of zeros is: " + p);
            }
            else
            {
                Console.WriteLine("ERROR: Not a valid entry, enter only positive numbers");
            }
        }
    }
}
