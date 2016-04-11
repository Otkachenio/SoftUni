using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\text.txt");
        StreamWriter writer = new StreamWriter(@"..\..\textWithLines.txt");
        string line;
        int count = 1;

        using (reader)
        using (writer)
        {
            while ((line = reader.ReadLine()) != null)
            {
                writer.Write("Line {0}: {1} \r\n", count, line);
                count++;
            }
        }
    }
}

