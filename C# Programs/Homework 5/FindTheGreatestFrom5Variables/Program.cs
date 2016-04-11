using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace FindTheGreatestFrom5Variables
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double a = 0, b = 0, c = 0, d = 0, e = 0;
            Console.Write("Enter your first variable, a :");
            bool checkA = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter your second variable, b :");
            bool checkB = double.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter your thrird variable, c :");
            bool checkC = double.TryParse(Console.ReadLine(), out c);
            Console.Write("Enter your fourth variable, d :");
            bool checkD = double.TryParse(Console.ReadLine(), out d);
            Console.Write("Enter your fiftth variable, e :");
            bool checkE = double.TryParse(Console.ReadLine(), out e);

            if (checkA && checkB && checkC && checkD && checkE)
            {
                Console.Write("The greatest number is: ");
                Console.WriteLine(Math.Max(Math.Max(Math.Max(Math.Max(a, b), c), d), e));
            }
            else
            {
                Console.WriteLine("Not a valid entry, enter double numbers only!");
            }
        }
    }
}
