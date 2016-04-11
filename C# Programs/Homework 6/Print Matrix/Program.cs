using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Please, enter a positive number < 20 : ");
            bool checkN = int.TryParse(Console.ReadLine(), out n);
            if (checkN && n > 0 && n < 20)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine();
                    for (int p = i; p < (n + i); p++)
                    {
                        if (p > 9)
                        {
                            Console.Write("{0} ", p);
                        }
                        else
                        {
                            Console.Write("{0}  ", p);
                        }
                        
                    }
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("ERROR: Not a valid entry, enter only positive numbers smallar than 20!");
            }
        }
    }
}
