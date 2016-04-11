using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKSum
{
    class Program
    {
        static void Main()
        {                                
            Console.Write("Please, enter how much elemets you watn in the array: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Plese, enter the number of element to be checked for maximal sum: ");
            int k = int.Parse(Console.ReadLine());
            int sum = 0;

            Console.Write("Please, enter the elemets of the array: ");
            string[] tokens = Console.ReadLine().Split(',');
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(tokens[i]);
            }
            Array.Sort(array);
            Console.WriteLine("----------------");
            for (int p = k; p > 0; p--)
            {
                sum += array[array.Length - p];
            }
            Console.WriteLine("Maximal sum of {0} element = {1} ", k, sum);
        }
    }
}
