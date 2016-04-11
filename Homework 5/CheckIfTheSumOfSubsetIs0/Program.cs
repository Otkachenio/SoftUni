using System;
using System.Collections.Generic;

namespace CheckIfTheSumOfSubsetIs0
{
    class Program
    {
        static void Main()
        {
            bool isInt = true;
            bool isElementZero = false;
            int[] intNumbers = new int[5];
            Console.Write("Enter a sequence of five integers delimited with \",\":");
            string[] strNumbers = (Console.ReadLine()).Split(',');
            if (strNumbers.Length == 5)
            {
                for (int i = 0; i < 5; i++)
                {
                    isInt = int.TryParse(strNumbers[i], out intNumbers[i]);
                    if (isInt == false)
                    {
                        break;
                    }
                    if (intNumbers[i] == 0)
                    {
                        isElementZero = true;
                    }
                }
                if (isInt)
                {
                    if (isElementZero)
                    {
                        Console.WriteLine("There is a subset with sum equal to 0");
                    }
                    else
                    {
                        switch (FindZeroSum(intNumbers))
                        {
                            case true: Console.WriteLine("There is a subset with sum equal to 0"); break;
                            case false: Console.WriteLine("There is no subset with sum equal to 0"); break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong entry! Some of the numbers are not integer!");
                }
            }
            else
            {
                Console.WriteLine("Wrong entry! The members of the sequence are less or more than 5!");
            }
        }
        private static bool FindZeroSum(int[] numbers)
        {
            int[] dynamicSums = new int[32];
            for (int i = 1; i < 5; i++)// numbers in the array
            {
                int j, k;
                for (j = 0; j < ((1 << i) - (i + 1)); j++)// the sum with already summed elements
                {

                    if ((dynamicSums[(1 << i) - (i + 1) + j] = numbers[i] + dynamicSums[j]) == 0)
                    {
                        return true;
                    }
                }
                for (k = 0; k < i; k++)// the sums with the new elements
                {
                    if ((dynamicSums[(1 << i) - (i + 1) + (j + k)] = numbers[k] + numbers[i]) == 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}