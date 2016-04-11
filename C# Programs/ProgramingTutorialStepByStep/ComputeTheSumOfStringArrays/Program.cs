using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeTheSumOfStringArrays
{
    class Program
    {
        static void Main()
        {
            double sum;
            string[] strs = { "3.45", "3.87", "87.98", "56.7" };
            Console.WriteLine("Numbers are: {0}, {1}, {2}, {3}", strs[0], strs[1], strs[2], strs[3]);
            double v0 = Convert.ToDouble(strs[0]);
            double v1 = Convert.ToDouble(strs[1]);
            double v2 = Convert.ToDouble(strs[2]);
            double v3 = Convert.ToDouble(strs[3]);
            sum = (v0 + v1 + v2 + v3);
            Console.WriteLine("The sum of the numbers is: " + sum);

            Console.WriteLine("---------------------");
            double total = 0.0;
            foreach (string temp in strs)
            {
                total += Convert.ToDouble(temp);
            }
            Console.WriteLine("Total = " + total);
        }
        
    }
}
