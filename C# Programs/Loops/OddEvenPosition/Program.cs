using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numbersCount = int.Parse(Console.ReadLine());
        List<double> oddList = new List<double>();
        List<double> evenList = new List<double>();
        List<double> numbersList = new List<double>();
        double oddSum = 0;
        double evenSum = 0;

        for(int i = 0; i < numbersCount; i++)
        {
            numbersList.Add(double.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < numbersList.Count; i += 2)
        {
            oddList.Add(numbersList[i]);
        }

        for (int i = 1; i < numbersList.Count; i += 2)
        {
            evenList.Add(numbersList[i]);
        }

        for (int i = 0; i < oddList.Count; i++)
        {
            oddSum += oddList[i];
        }

        for (int i = 0; i < evenList.Count; i++)
        {
            evenSum += evenList[i];
        }

        Console.WriteLine("OddSum={0},", oddSum);
        if (oddList.Count > 0)
        {
            Console.WriteLine("OddMin={0},", oddList.Min());
            Console.WriteLine("OddMax={0},", oddList.Max());
        }
        else
        {
            Console.WriteLine("OddMin=No,");
            Console.WriteLine("OddMax=No,");
        }

        Console.WriteLine("EvenSum={0},", evenSum);
        if (evenList.Count > 0)
        {
            Console.WriteLine("EvenMin={0},", evenList.Min());
            Console.WriteLine("EvenMax={0}", evenList.Max());
        }
        else
        {
            Console.WriteLine("EvenMin=No,");
            Console.WriteLine("EvenMax=No");
        }
    }
}