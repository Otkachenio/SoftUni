using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static List<string> Words()
    {
        StreamReader reader = new StreamReader(@"..\..\words.txt");
        List<string> list = new List<string>();
        string line;

        using (reader)
        {
            while((line = reader.ReadLine()) != null)
            {
                string[] split = line.Split(' ');
                for (int i = 0; i < split.Length; i++)
                {
                    list.Add(split[i]);
                }
            }
        }
        return list;
    }

    static List<string> Text()
    {
        StreamReader reader = new StreamReader(@"..\..\test.txt");
        List<string> list = new List<string>();
        string line;

        using (reader)
        {
            while ((line = reader.ReadLine()) != null)
            {
                string[] split = line.Split(' ');
                for (int i = 0; i < split.Length; i++)
                {
                    list.Add(split[i]);
                }
            }
        }
        return list;
    }

    static void Main()
    {
        try
        {
            StreamWriter writer = new StreamWriter(@"..\..\result.txt");
            List<string> wordsList = Words();
            List<string> textList = Text();
            List<string> resultList = new List<string>();
            string word = "";
            int count = 0;

            for (int i = 0; i < wordsList.Count; i++)
            {
                count = 0;
                for (int j = 0; j < textList.Count; j++)
                {
                    if (textList[j] == wordsList[i])
                    {
                        word = textList[j];
                        count++;
                    }
                }
                if (count > 0)
                {
                    resultList.Add(count.ToString() + " " + word);
                }
            }
            resultList.Sort();

            using (writer)
            {
                for (int i = resultList.Count - 1; i >= 0; i--)
                {
                    writer.WriteLine(resultList[i]);
                }
            }
            Console.WriteLine("Done!");
        }

        catch (FileNotFoundException e)
        {
            Console.WriteLine("File not Found: \r\n" + e);
        }
        
        catch (DirectoryNotFoundException e)
        {
            Console.WriteLine("Directory not found: \r\n" + e);
        }

        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine("Unauthorized Access: \r\n" + e);
        }

        catch (IOException e)
        {
            Console.WriteLine("Input\\Output ERROR: \r\n" + e);
        }
    }
}