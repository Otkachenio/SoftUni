using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> inputList = new List<string>();
        List<string> outputList = new List<string>();
        string input = Console.ReadLine();
        double counter = 1;
        double time = 0;
        string[] tokens = new string[2];
        string[] tokensTwo = new string[2];

        while (input.Length > 10)
        {
            tokens = input.Split(' ');
            inputList.Add(tokens[2] + " " + tokens[3]);

            input = Console.ReadLine();
        }

        inputList.Sort();

        for (int i = 1; i < inputList.Count; i++)
        {
            tokens = inputList[i - 1].Split(' ');
            tokensTwo = inputList[i].Split(' ');
            if (tokens[0] == tokensTwo[0])
            {
                counter++;
                time += double.Parse(tokens[1]);
            }
            else
            {
                time += double.Parse(tokens[1]);
                time = time / counter;
                outputList.Add(tokens[0] + " -> " + time.ToString());
                time = 0;
                counter = 1;
            }
        }
        time += double.Parse(tokensTwo[1]);
        time = time / counter;
        outputList.Add(tokens[0] + " -> " + time.ToString());

        foreach (var item in outputList)
        {
            Console.WriteLine(item);
        }
    }
}