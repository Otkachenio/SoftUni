using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class Program
    {
        static void Main()
        {
            string[] tokens1 = Console.ReadLine().Split(); 
            string[] tokens2 = Console.ReadLine().Split(); 

            int[] array1 = new int[tokens1.Length];
            int[] array2 = new int[tokens2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = int.Parse(tokens1[i]);
                array2[i] = int.Parse(tokens2[i]);

                if (array1[i] == array2[i])
                {
                    Console.WriteLine("element{0} = element{0}", i+1);
                }
            }
        }
    }
}
