using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\test.txt");
        StreamWriter writer = new StreamWriter(@"..\..\Result.txt");

        Console.Write("Please, enter the prefix you want to remove: ");
        string prefix = Console.ReadLine();
        string clearText = "";
        string line;
        bool check = false; //checking for empty rows
        
        List<string> listStr = new List<string>();

        using (reader)
        {
            while ((line = reader.ReadLine()) != null)
            {
                string[] tokens = line.Split(' ');

                for (int i = 0; i < tokens.Length; i++)
                {
                    if (tokens[i].Length >= prefix.Length)
                    {
                        string str = tokens[i].Substring(0, prefix.Length);

                        if (str.ToLower() == prefix)
                        {
                            continue;
                        }
                        else
                        {
                            clearText = clearText + tokens[i] + " ";
                            check = true;
                        }
                    }
                    else
                    {
                        clearText = clearText + tokens[i] + " ";
                        check = true;
                    }
                }
                if (check)
                {
                    clearText = clearText + "\r\n";
                }
                check = false;    
            }
        }

        using (writer)
        {
            writer.Write(clearText);
        }
    }
}