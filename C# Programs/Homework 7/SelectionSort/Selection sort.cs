using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter numbers in the array, separated by \",\": ");
            string[] tokens = Console.ReadLine().Split(',');
            int[] array = new int[tokens.Length];
            int i, exchange;

            for (int a = 0; a < array.Length; a++)
            {
                array[a] = int.Parse(tokens[a]);
            }

            for (int j = 0; j < array.Length - 1; j++)
            {
                int minI = j;

                for (i = j + 1; i < array.Length; i++)
                {
                    if (array[minI] > array[i])
                    {
                        minI = i;
                    }
                }
                if (minI != j)
                {
                    exchange = array[j];
                    array[j] = array[minI];
                    array[minI] = exchange;
                }
            }
            Console.WriteLine("------------");
            Console.Write("Your sorted array: ");
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[k]);
                if (k < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.ReadLine();    
        }
    }
}
