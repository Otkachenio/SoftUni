using System;
using System.IO;

class Program
{
    static void Main()
    {
        int counter = 1;
        string line;
        string fileName = @"..\..\text.txt";

        StreamReader reader = new StreamReader(fileName);

        using (reader)
        {
            while ((line = reader.ReadLine()) != null)
            {
                if (counter % 2 != 0)
                {
                    Console.WriteLine("Line {0}: {1}", counter, line);
                }
                counter++;
            }
        }
        Console.WriteLine("Odd lines = {0}", counter/2);
    }
}

