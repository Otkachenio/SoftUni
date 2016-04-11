using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Test.txt");
        StreamWriter writer = new StreamWriter(@"..\..\Writen.txt");
        string line;
        string replacedString;
        //Console.Write("Enter the word you want to replace: ");
        //string word = Console.ReadLine();
        //Console.Write("Enter the new word for raplacment: ");
        //string replace = Console.ReadLine();

        using (reader)
        using (writer)
        {
            while ((line = reader.ReadLine()) != null)
            {
                replacedString = Regex.Replace(line, @"\bstart\b", "finish");
                writer.Write("{0} \r\n", replacedString);
            }
        }
    }
}

