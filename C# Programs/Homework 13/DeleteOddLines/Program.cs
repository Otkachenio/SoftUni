using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        StreamReader textReader = new StreamReader(@"..\..\text.txt");
        
        List<string> wholeText = new List<string>();
        int counter = 1;
        string line;

        using (textReader)
        {
            while ((line = textReader.ReadLine()) != null)
            {
                if (counter % 2 != 0)
                {
                    wholeText.Add(line);
                }
                counter++;
            }
        }

        StreamWriter textWriter = new StreamWriter(@"..\..\text.txt");

        using (textWriter)
        {
            for (int i = 0; i < wholeText.Count; i++)
            {
                textWriter.Write("{0}\r\n", wholeText[i]);
            }
        }
    }
}

