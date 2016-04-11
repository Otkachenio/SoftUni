using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter you sequence, devide the numbers with \",\" : ");
            string[] tokens = Console.ReadLine().Split(',');
            int[] array = new int[tokens.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(tokens[i]);
            }
            Console.Write("Please, enter the number wich position you seek: ");
            int x = int.Parse(Console.ReadLine());
            int count = 0;
            bool check = false;
            int midPoint = array.Length / 2;
            if (x > array.Max())
            {
                Console.WriteLine("The number that you seek isn't in this sequence!");
            }
            else
            {
                while (count < midPoint)
                {
                    if (array[midPoint] < x)
                    {
                        midPoint++;
                    }
                    else if (array[midPoint] > x)
                    {
                        midPoint--;
                    }
                    else
                    {
                        Console.WriteLine("The idex of your element is: " + (midPoint + 1));
                        break;
                    }
                    count++;
                }
                if (!check)
                {
                    Console.WriteLine("The number that you seek isn't in this sequence!");
                }
            } 
        }
    }
}
