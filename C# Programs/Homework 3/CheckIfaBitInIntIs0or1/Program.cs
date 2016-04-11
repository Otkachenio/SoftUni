using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfaBitInIntIs0or1
{
    class Program
    {
        static void Main()
        {
            bool check = false;
            int v;
            byte p;
            Console.Write("Enter the number v: ");
            bool checkV = int.TryParse(Console.ReadLine(), out v);
            Console.Write("Enter the bit position p:  ");
            bool checkP = byte.TryParse(Console.ReadLine(), out p);
            if (checkP && checkV && p<32)
            {
                Console.Write("The number {0} in bits is: ", v);
                Console.WriteLine(Convert.ToString(v, 2));
                int mask = 1 << p;
                if ((v & mask) == mask)
                {
                    check = true;
                }
                Console.WriteLine("Is bit {0} of intiger {1} equal to 1?:{2}", p, v, check);
            }
            else
            {
                Console.WriteLine("Not a valid Entry!");
            }
        }
    }
}
