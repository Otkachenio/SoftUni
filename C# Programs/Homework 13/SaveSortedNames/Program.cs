using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader unsortedReader = new StreamReader(@"..\..\Unsorted.txt");
        StreamWriter sortedWriter = new StreamWriter(@"..\..\Sorted.txt");
        List<string> listOfNames = new List<string>();
        string name;

        using (unsortedReader)
        {
            while ((name = unsortedReader.ReadLine()) != null)
            {
                listOfNames.Add(name);
            }

            listOfNames.Sort();
        }

        using (sortedWriter)
        {
            for (int i = 0; i < listOfNames.Count; i++)
            {
                sortedWriter.Write("{0} \r\n", listOfNames[i]);
            }
        }
    }
}