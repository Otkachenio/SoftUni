using System;

namespace TrapezoidAreaCalculation
{
    class Program
    {
        static void Main()
        {
            double a;
            double b;
            double h;
            Console.Write("Enter value for side a: ");
            bool ItsNumbera = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter value for side b: ");
            bool ItsNumberb = double.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter value for height h: ");
            bool ItsNumberh = double.TryParse(Console.ReadLine(), out h);
            if (ItsNumbera && ItsNumberb && ItsNumberh)
            {
                double area = ((a + b) / 2) * h;
                Console.WriteLine("The Trapezoid area is: {0}", area);
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
