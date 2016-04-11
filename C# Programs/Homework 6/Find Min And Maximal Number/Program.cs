using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Find_Min_And_Maximal_Number
{
    class Program
    {
        static void Main()
        {
            int[] numbers;
            int sequence;
            int i = 0;
            Console.Write("How much numbers do you want to check? :");
            bool checkSequence = int.TryParse(Console.ReadLine(), out sequence);
            if (checkSequence && sequence >= 1)
            {
                numbers = new int[sequence];
                do
                {
                    Console.Write("Enter a number: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                    i++;
                    
                }
                while (i <= sequence-1);
                int min = numbers.Min();
                int max = numbers.Max();
                Console.WriteLine("Maximal: " + max);
                Console.WriteLine("Minimal: " + min);
            }
            else
            {
                Console.WriteLine("ERROR, your sequence must be positive integer number");
            }
        }
    }
}
