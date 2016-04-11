using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main()
        {
            int[] array = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
            int start = 0;
            int maximalSum = 0, countStart = 0, countTake = 0;
            int sum = 0;
            
            while (start < array.Length)
            {

                int count = 1;
                sum += array[start];
                if (maximalSum < sum)
                {
                    maximalSum = sum;
                    countTake = start - countStart + 1;
                }
                if (sum < 0)
                {
                    sum = 0;
                    countStart = start + 1;
                }
                start += count;
            }
            Console.WriteLine("-----------");
            Console.WriteLine("Sequence of maximal sum: {0}", string.Join(", ", array.Skip(countStart).Take(countTake)));
        }
    }
}
