using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] array = new string[] { "CHU", "TEL", "OFT", "IVA", "EMY", "VNB", "POQ", "ERI",
            "CAD", "K-A", "IIA","YLO", "PLA" };
        List<int> list = new List<int>();

        string input = Console.ReadLine();
        string str = null;

        decimal sum = 0;
        decimal multiplayer = 1;

        for (int i = 0; i < input.Length; i += 3)
        {
            for (int j = i; j < i + 3; j++)
            {
                str += input[j];
            }

            for (int g = 0; g < array.Length; g++)
            {
                if (array[g] == str)
                {
                    list.Add(g);
                    break;
                }
            }
            str = null;
        }

        for (int i = list.Count - 1; i >= 0; i--)
        {
            sum += (list[i] * multiplayer);
            multiplayer *= 13;
        }
        Console.WriteLine(sum);
    }
}