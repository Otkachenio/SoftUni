using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxExample
{
    class TestBox
    {
        static void Main()
        {
            Box ups, fedEx;

            ups = new Box();
            ups.lenght = 10;
            ups.width = 5;
            Console.Write("ups box ");
            int total = ups.CalculateArea();

            fedEx = new Box();
            fedEx.lenght = 7;
            fedEx.width = 5;
            Console.Write("fedEx box ");
            total += fedEx.CalculateArea();

            Console.WriteLine("Total Area: " + total);
        }
    }
}
