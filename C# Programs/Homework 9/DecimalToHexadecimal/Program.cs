using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class Program
    {
        static void Main()
        {
            int input;
            List<char> hexaList = new List<char>();
            Console.Write("Please, enter your decimal number: ");
            bool checkInput = int.TryParse(Console.ReadLine(), out input);
            int hexaNumber = 0;
            int hexaInt = 0;

            if (checkInput)
            {
                while (input > 0)
                {
                    hexaNumber = input % 16;
                    if (hexaNumber >= 10)
                    {
                        hexaNumber -= 10;
                        hexaInt = hexaNumber + 'A';
                    }
                    else
                    {
                        hexaInt = hexaNumber + '0';
                    }
                    hexaList.Add((char)hexaInt);
                    input /= 16;
                }
                hexaList.Reverse();

                Console.Write("Your numer in hexadecimal: ");
                foreach (var a in hexaList)
                {
                    Console.Write(a);
                }
                Console.ReadLine(); 
            }
            else
            {
                Console.WriteLine("Not a valid entry!");
            }
        }
    }
}
