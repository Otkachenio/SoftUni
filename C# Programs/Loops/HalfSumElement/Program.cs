using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numbersCount = int.Parse(Console.ReadLine());
        List<int> numbersList = new List<int>();

        for (int i = 0; i < numbersCount; i++)
        {
            numbersList.Add(int.Parse(Console.ReadLine()));
        }

        int maxNumber = numbersList.Max();
        int numbersSum = 0;
        int numbersDiff = 0;

        for (int i = 0; i < numbersList.Count; i++)
        {
            numbersSum += numbersList[i];
        }

        numbersSum -= maxNumber;
        numbersDiff = maxNumber - numbersSum;

        if (numbersDiff < 0)
        {
            numbersDiff *= -1;
        }

        if (numbersSum == maxNumber)
        {
            Console.WriteLine("Yes");
            Console.WriteLine("Sum = {0}", numbersSum);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("Diff {0}", numbersDiff);
        }
    }
}