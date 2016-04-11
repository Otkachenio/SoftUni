using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        var numbersAsString = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder encodedString = new StringBuilder();
        foreach(var str in numbersAsString)
        {
            var num = int.Parse(str);
            encodedString.Append(Convert.ToString(num, 2).PadLeft(8, '0'));
        }

        int n = int.Parse(Console.ReadLine());
        char[] dictionary = new char[n + 1];
        for (int i = 0; i < n; i++)
        {
            var line = Console.ReadLine();
            char symbol = line[0];
            int index = int.Parse(line.Substring(1));
            dictionary[index] = symbol;
        }

        StringBuilder decodet = new StringBuilder();

        int ones = 0;

        foreach (var ch in encodedString.ToString())
        {
            if (ch == '1')
            {
                ones++;
            }
            else
            {
                decodet.Append(dictionary[ones]);
                ones = 0;
            }
        }

        if (ones > 0)
        {
            decodet.Append(dictionary[ones]);
        }

        Console.WriteLine(decodet);
    }
}
