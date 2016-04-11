using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numberOfPairs = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        int num1 = 0;
        int num2 = 0;
        int sum = 0;
        int value = 0;
        int maxDiff = 0;
        
        for (int i = 0; i < numberOfPairs; i++)
        {
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            sum = num1 + num2;

            numbers.Add(sum);
        }

        bool check = true;

        if (numbers.Count == 1)
        {
            value = numbers[0];
        }

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] == numbers[i-1])
            {
                value = numbers[i];
            }
            else
            {
                check = false;
                maxDiff = numbers.Max() - numbers.Min();
                break;
            }
        }
        if (check)
        {
            Console.WriteLine("Yes, value={0}", value);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}