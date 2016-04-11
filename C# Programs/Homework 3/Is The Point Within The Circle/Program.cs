using System;

namespace Is_The_Point_Within_The_Circle
{
    class Program
    {
        static void Main()
        {
            bool check = false;
            double x;
            double y;
            Console.Write("Enter value for x: ");
            bool ItsNumber = double.TryParse(Console.ReadLine(), out x);
            Console.Write("Enter value for y: ");
            bool ItsNumber2 = double.TryParse(Console.ReadLine(), out y);
            if (ItsNumber && ItsNumber2)
            {
                if ((x * x + y * y) <= 25)
                {
                    check = true;
                }
                Console.WriteLine("Is the point ({0},{1}) within the circle?: {2}", x, y, check);
            }
            else
            {
                Console.WriteLine("Not a valid Entry!");
            }

        }
    }
}
