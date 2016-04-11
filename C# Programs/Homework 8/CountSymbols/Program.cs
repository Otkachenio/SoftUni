using System;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main()
        {
            string imput = Console.ReadLine();

            imput.Count();

            var counts = imput.GroupBy(c => c).OrderBy(c => c.Key).ToDictionary(grp => grp.Key, grp => grp.Count());

            foreach (var c in counts)
            {
                Console.WriteLine($"{c} time/s");
            }
        }
    }
}
