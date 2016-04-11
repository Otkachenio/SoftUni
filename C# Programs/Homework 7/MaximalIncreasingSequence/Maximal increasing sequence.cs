using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] testArray = { 3, 2, 3, 4, 1, 3, 4, 3, 5 };
        int bestCount = 0;
        int bestStart = 0;
        int start = 0;

        while (start < testArray.Length)
        {
            int count = 1;
            int k = start + 1;
            while(k < testArray.Length && testArray[k] == testArray[k-1] + 1)
            {
                k++;
                count++;
            }
            if (bestCount < count)
            {
                bestStart = start;
                bestCount = count;
            }
            start += count;
        }
        Console.WriteLine("Longest sequnce is: {0}", string.Join(",", testArray.Skip(bestStart).Take(bestCount)));
    }
}