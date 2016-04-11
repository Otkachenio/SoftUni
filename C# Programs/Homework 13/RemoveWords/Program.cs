using System;
using System.Collections.Generic;
using System.IO;

class RemoveAllListedWords
{
    static List<string> GetWords()
    {
        StreamReader reader = new StreamReader(@"..\..\Remove.txt");
        List<string> list = new List<string>();

        using (reader)
        {
            string word = reader.ReadLine();
            while (word != null)
            {
                list.Add(word);
                word = reader.ReadLine();
            }
        }
        return list;
    }

    static void Main()
    {
        try
        {
            List<string> list = GetWords();
            StreamReader reader = new StreamReader(@"..\..\Text.txt");
            StreamWriter writer = new StreamWriter(@"..\..\Result.txt");

            using (reader)
            using (writer)
            {
                string line = reader.ReadLine();
                string test;
                while (line != null)
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        string word = list[i];
                        line = line.Replace(word, "");
                    }
                    test = line.Replace(" ", string.Empty);
                    if (test.Length > 0)
                    {
                        writer.WriteLine(line);
                    }

                    line = reader.ReadLine();
                }
            }
            Console.WriteLine("Done!");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}