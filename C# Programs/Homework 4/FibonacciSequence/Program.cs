using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSequence
{
    class Program
    {
        static void Main()
        {
            decimal a = 0;
            decimal b = 1;
            decimal f = 0;
            Console.WriteLine(f);
            for (decimal n = 0; n < 100; n++)
            {
                decimal temp = a;
                a = b;
                b = temp + b;
                Console.WriteLine(a);
                
            }
        }
    }
}
