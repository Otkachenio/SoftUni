using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateTheSum
{
    class Program
    {
        static void Main()
        {
            //Write a program to calculate the sum(with accuracy of 0.001): 1 + 1 / 2 – 1 / 3 + 1 / 4 – 1 / 5 + …
            float i = 2;
            float newMembre;
            float sum = 1;
            do
            {
                if (i % 2 == 0)
                {
                    newMembre = 1 / i;
                }
                else
                {
                    newMembre = -1 / i;
                }
                i++;
                sum = sum + newMembre;
            } while (Math.Abs(newMembre) > 0.0001f);
            Console.WriteLine("sum={0:F3}", sum);
        }
    }
}
