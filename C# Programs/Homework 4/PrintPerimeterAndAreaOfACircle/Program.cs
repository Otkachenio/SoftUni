using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPerimeterAndAreaOfACircle
{
    class Program
    {
        static void Main()
        {
            double r, area, p;
            Console.Write("Please, enter the radius \"r\" of the circle: ");
            bool checkR = double.TryParse(Console.ReadLine(), out r);
            if (checkR)
            {
                area = (r * r) * Math.PI;
                p = (2 * r) * Math.PI;
                Console.WriteLine("Your circle has perimeter = {0} and area = {1}", p, area);
            }
            else
            {
                Console.WriteLine("Not a valid Entry!");
            }
        }
    }
}
