using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxExample
{
    class Box
    {
        public int lenght, width;

        public int CalculateArea()
        {
            int area = lenght * width;
            Console.WriteLine("Area = " + area);
            return area;
        }
    }
}
