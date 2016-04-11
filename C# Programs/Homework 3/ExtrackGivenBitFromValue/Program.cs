using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtrackGivenBitFromValue
{
    class Program
    {
        static void Main()
        {
            // Write an expression that extracts from a given integer i the value of a given bit number b.
            //Example: i=5; b=2 => value=1.
            int i;
            byte b;
            Console.Write("Please, enter your integer number: ");
            bool checkI = int.TryParse(Console.ReadLine(), out i);
            Console.Write("Please, enter the postion of the bit: ");
            bool CheckB = byte.TryParse(Console.ReadLine(), out b);
            if (checkI && CheckB && b<32)
            {
                Console.WriteLine("Your number in bits: " + Convert.ToString(i,2));
                Console.WriteLine("----------------");
                int mask = 1 << b;
                if ((i & mask) == mask)
                {
                    Console.WriteLine("Your bit in position {0} is: 1", b);
                }
                else
                {
                    Console.WriteLine("Your bit in position {0} is: 0", b);
                }
            }
            else
            {
                Console.WriteLine("Not a valid Entry!");
            }
        }
    }
}
