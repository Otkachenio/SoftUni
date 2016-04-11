using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSequence
{
    class Program
    {
        static void Main()
        {
            string[] tokens = Console.ReadLine().Split(',');
            int[] array = new int[tokens.Length + 1];
            int counter = 1, sequence = 0, sequenceNumer = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                array[i] = int.Parse(tokens[i]);

                if (array[i - 1] == array[i])
                {
                    counter++;
                    if (sequence < counter)
                    {
                        sequence = counter;
                        sequenceNumer = array[i];
                    }
                }
                else
                {
                    counter = 1;
                }
                
            }
            Console.WriteLine("---------");

            for (int p = 1; p <= sequence; p++)
            {
                Console.Write(sequenceNumer);
                if (p != sequence)
                {
                    Console.Write(", ");
                }
                    
            }
            Console.ReadLine();
        }
    }
}
