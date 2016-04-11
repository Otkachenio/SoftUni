using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNameOfTheDigit
{
    class Program
    {
        static void Main()
        {
            //Write program that asks for a digit and depending 
            //on the input shows the name of that digit (in English) using a switch statement.
            byte a;
            string b;
            b = null;
            Console.Write("Please, enter a digit: ");
            bool checkA = byte.TryParse(Console.ReadLine(), out a);
            if (checkA && a>=0 && a<=9)
            {
                switch (a)
                {
                    case 0:
                        b = "Zero";
                        break;
                    case 1:
                        b = "One";
                        break;
                    case 2:
                        b = "Two";
                        break;
                    case 3:
                        b = "Three";
                        break;
                    case 4:
                        b = "Four";
                        break;
                    case 5:
                        b = "Five";
                        break;
                    case 6:
                        b = "Six";
                        break;
                    case 7:
                        b = "Seven";
                        break;
                    case 8:
                        b = "Eight";
                        break;
                    case 9:
                        b = "Nine";
                        break;
                }
                Console.WriteLine("You digit is: " + b);

            } 
            else
            {
                Console.WriteLine("Not a valid entry, you should enter a digit (0-9)!");
            }
        }
    }
}
