using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Test100MB.txt");
        StreamWriter writer = new StreamWriter(@"..\..\Test1.txt");
        string line;
        string replacedString;

        using (reader)
        using (writer)
        {
            while((line = reader.ReadLine()) != null)
            {
                replacedString = line.Replace("start", "finish");
                writer.Write("{0} \r\n", replacedString);
            }
        }
    }
}

