using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationSolution
{
    class Program
    {
        static void Main()
        {
            //Write a program that reads the coefficients a, b and c of a quadratic 
            //equation ax2+bx+c=0 and solves it (prints its real roots).
            double a, b, c, D, x1, x2;
            Console.Write("Please, enter the first coefficient a: ");
            bool checkA = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Please, enter the second coefficient b: ");
            bool checkB = double.TryParse(Console.ReadLine(), out b);
            Console.Write("Please, enter the third coefficient c: ");
            bool checkC = double.TryParse(Console.ReadLine(), out c);
            if (checkA && checkB && checkC && a!= 0)
            {
                D = (b * b) - ((4 * a) * c);
                if (D > 0)
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                    Console.WriteLine("Root x1 = {0} \n \rRoot x2 = {1}", x1, x2);
                }
                else if (D == 0)
                {
                    x1 = (-b) / (2 * a);
                    Console.WriteLine("Root x1 = {0} \n \rRoot x2 = {1}", x1, x1);
                }
                else
                {
                    Console.WriteLine("Negative Discriminant (D<0), There are No Real Roots");
                }
            }
            else
            {
                Console.WriteLine("Not a valid entry, please enter double numbers, and first coefficient a - different from 0");
            }
        }
    }
}
