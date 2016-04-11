using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSmallBox
{
    class TestSmallBox
    {
        static void Main()
        {
            //We don't need to enter data for length and width, because it's the default data assigned by the constructor.
            //The Constructor has the same name as the class!
            SmallBox fedEx1 = new SmallBox();
            //fedEx.lenght = 5; - not needet (default - assigned by the constructor)
            //fedEx.width = 6; - ---
            fedEx1.CalculateArea();

            SmallBox fedEx2 = new SmallBox();
            //ups.lenght = 5; - ---
            //ups.width = 6; - ---
            fedEx2.CalculateArea();

            //And we can use second constructor on which we can assign different values
            //The Program checks which constructor accepts new data and uses it...
            SmallBox ups2 = new SmallBox(3, 4);
            ups2.CalculateArea();

            SmallBox ups1 = new SmallBox();
            ups1.CalculateArea(); // again the default data in the first constructor is used


        }
    }
}
