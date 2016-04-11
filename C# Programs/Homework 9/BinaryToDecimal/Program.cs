using System;
using System.Collections.Generic;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter your binary number(whitout spaces): ");
            string input = Console.ReadLine();
            List<int> binaryList = new List<int>();
            int bitM = 1;
            int number = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int bit = input[i] - '0';
                if (bit != 1 && bit != 0)
                {
                    Console.WriteLine("Invalid entry, enter only bits(1 or 0)!");
                    return;
                }
                binaryList.Add(bit);
            }

            for (int a = 0; a < binaryList.Count; a++)
            {
                number += binaryList[a] * bitM;
                bitM *= 2;
            }
            Console.WriteLine("Your decimal number is: {0}", number);
        }
    }
}
