using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeBitOnGivenPosition
{
    class Program
    {
        static void Main()
        {
            int n;
            byte p;
            byte v;
            Console.Write("Please, enter your number: ");
            bool checkN = int.TryParse(Console.ReadLine(), out n);
            Console.Write("Please, enter the bit position: ");
            bool checkP = byte.TryParse(Console.ReadLine(), out p);
            Console.Write("Please, enter the bit value: ");
            bool checkV = byte.TryParse(Console.ReadLine(), out v);
            if (checkN && checkP && checkV && p<32 && v<=1)
            {
                int mask = v << p;
                if (v == 1)
                {
                    n = mask | n;
                }
                else
                {
                    n &= ~(1 << p);
                }
                Console.WriteLine("Your new number is: {0}", n);
            }
            else
            {
                Console.WriteLine("Not a valid Entry!");
            }
        }
    }
}
