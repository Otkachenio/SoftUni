using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class Program
    {
        static void Main()
        {
            int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            int start = 0, mostFrequent = 0, counter = 0, wCount = 0;
            Array.Sort(array);

            while (start < array.Length)
            {
                int count = 1;
                int frequent = array[start];
                while (wCount < array.Length)
                {
                    if (frequent == array[wCount])
                    { 
                        count++;
                        if (counter < count)
                        {
                            counter = count - 1;
                            mostFrequent = array[start];
                        }
                        
                    }
                    wCount++;
                }
                start++;
                wCount = 0;
            }
            Console.WriteLine("{0} ({1} times)", mostFrequent, counter);
            Console.ReadLine();
        }
    }
}
