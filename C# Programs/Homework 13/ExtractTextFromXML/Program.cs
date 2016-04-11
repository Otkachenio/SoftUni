using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    public static void Main()
    {
        StreamReader XMLText = new StreamReader(@"..\..\XMLText.xml");
        StreamWriter ClearText = new StreamWriter(@"..\..\ClearText.txt");

        string wholeText;
        int counter = 1;

        using (XMLText)
        {
            wholeText = XMLText.ReadToEnd();
            while (wholeText.IndexOf("<") >= 0)
            {
                int index1 = wholeText.IndexOf("<");
                int index2 = wholeText.IndexOf(">", index1 + 1);
                string result2 = wholeText.Remove(index1, index2 + 1 - index1);
                counter++;
                wholeText = result2;
            }
        }

        var replacer = new Regex(@"
                (?<=[A-Z])(?=[A-Z][a-z]) |
                 (?<=[^A-Z])(?=[A-Z]) |
                 (?<=[A-Za-z])(?=[^A-Za-z])", RegexOptions.IgnorePatternWhitespace);

        using (ClearText)
        {
            ClearText.Write("{0}", replacer.Replace(wholeText, " "));
        }
    }
}