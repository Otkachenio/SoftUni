using System;
using System.IO;

class Program
{
    static void Main()
    {
        string file1Text;
        string file2Text;

        StreamReader file1Reader = new StreamReader(@"..\..\text1.txt");
        StreamReader file2Reader = new StreamReader(@"..\..\text2.txt");
        StreamWriter fileWriter = new StreamWriter(@"..\..\concatenatedText.txt");

        using (file2Reader)
        using (file1Reader)
        {
            file1Text = file1Reader.ReadToEnd();
            file2Text = file2Reader.ReadToEnd();
        }

        using (fileWriter)
        {
            fileWriter.Write(file1Text);
            fileWriter.Write(file2Text);
        }
    }
}

