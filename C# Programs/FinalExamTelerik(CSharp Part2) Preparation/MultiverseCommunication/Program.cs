using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        TranslateInput translate = new TranslateInput();

        Console.Write("Enter the massage: ");
        string input = Console.ReadLine();
        string massage = null;
        int p = 0;
        int numeralSystem = 1;
        List<string> massageList = new List<string>();
        List<decimal> outputList = new List<decimal>();
        decimal sum = 0;

        for (int i = 0; i < input.Length; i += 3)
        {
            for (int j = i; j < i + 3; j++)
            {
                massage += input[j];
            }
            massageList.Add(massage);
            massage = null;
        }

        for (int i = massageList.Count - 1; i >= 0; i--)
        {
            p = translate.toNumber(massageList[i]);
            outputList.Add(p * numeralSystem);
            numeralSystem *= 13;
        }

        foreach (var item in outputList)
        {
            sum += item;
        }

        Console.WriteLine(sum);

    }
}

