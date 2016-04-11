using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToDecimal
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter your hexadecimal number (Whitout spaces): ");
            string input = Console.ReadLine();
            List<int> hexaList = new List<int>();
            int number = 0;
            int temp = 0;
            int hexaM = 1;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] - '0' >= 10)
                {
                    temp = input[i] - 'A';
                    temp += 10;
                    if (temp > 15)
                    {
                        Console.WriteLine("Not a valid entry, only hexadecimal numbers(0 - F)!");
                        return;
                    }
                    hexaList.Add(temp);
                }
                else
                {
                    temp = input[i] - '0';
                    hexaList.Add(temp);
                }
            }
            hexaList.Reverse();
            
            foreach (var p in hexaList)
            {
                number += (p * hexaM);
                hexaM *= 16;
            }
            Console.WriteLine("The decimal representation of your numer is: {0}",number);
        }
    }
}
