using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSmallBox
{
    class SmallBox
    {
        public int lenght, width;

        public SmallBox()
        {
            lenght = 6;
            width = 5;
        }
        public void CalculateArea()
        {
            Console.WriteLine("Area = " + (lenght * width));
        }
        public SmallBox(int lenght, int width)
        {
            this.lenght = lenght;
            this.width = width;
        }
    }
}
