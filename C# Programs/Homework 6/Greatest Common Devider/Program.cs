using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Devider
{
    class Program
    {
        static void Main()
        {
            uint num1, num2;
            Console.Write("Please, enter your first number: ");
            bool checkNum1 = uint.TryParse(Console.ReadLine(), out num1);
            Console.Write("Please, enter your second number: ");
            bool checkNum2 = uint.TryParse(Console.ReadLine(), out num2);
            if (checkNum1 && checkNum2)
            { 
                while (num1 != 0 && num2 != 0)
                {
                    if (num1 > num2)
                    {
                        num1 -= num2;
                    }
                    else
                    {
                        num2 -= num1;
                    }
                }
                Console.Write("The greatest common divisor = ");
                Console.WriteLine(Math.Max(num1, num2));
            }
            else
            {
                Console.WriteLine("ERROR: Not a valid entry, enter only integer numbers!");
            }
        }
    }
}
