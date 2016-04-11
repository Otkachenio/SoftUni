using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int range;
            Console.Write("Please, enter a digit in the range of [1-9]: ");
            bool checkRange = int.TryParse(Console.ReadLine(), out range);
            if (checkRange && range  <= 9 && range > 0)
            {
                switch (range)
                {
                    case 1:
                    case 2:
                    case 3:
                        range = range + 10;
                        break;
                    case 4:
                    case 5:
                    case 6:
                        range = range + 100;
                        break;
                    case 7:
                    case 8:
                    case 9:
                        range = range + 1000;
                        break;
                }
                Console.WriteLine("Score: " + range);     
            }
            else
            {
                Console.WriteLine("Error, only digits in range of [1 to 9]!");
            }
        }
    }
}
