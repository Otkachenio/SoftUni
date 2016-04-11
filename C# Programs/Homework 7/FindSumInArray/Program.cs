using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumInArray
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter your sequence, devide numbers by\",\": ");
            string[] tokens = Console.ReadLine().Split(',');
            int[] array = new int[tokens.Length];
            Console.Write("Please, enter the sum you want to find: ");
            int s = int.Parse(Console.ReadLine());
            for (int p = 0; p < array.Length; p++)
            {
                array[p] = int.Parse(tokens[p]);
            }
            int sum = 0;
            bool check = false;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    sum += array[j];
                    if (sum == s)
                    {
                        check = true;
                        Console.Write("Sequence with sum of {0}: ", s);
                        for (int count = i; count <= j; count++)
                        {
                            Console.Write(array[count]);
                            if (count<j)
                            {
                                Console.Write(", ");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                sum = 0;
            }
            if (!check)
            {
                Console.WriteLine("The isn't a sequence with sum of {0}.", s);
            }
        }
    }
}