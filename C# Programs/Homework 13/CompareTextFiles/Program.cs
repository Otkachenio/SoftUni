using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader text1Reader = new StreamReader(@"..\..\text1.txt");
        StreamReader text2Reader = new StreamReader(@"..\..\text2.txt");
        string lineText1;
        string lineText2;
        int sameLines = 0, differentLines = 0;

        using (text1Reader)
        using (text2Reader)
        {
            lineText1 = text1Reader.ReadLine();
            lineText2 = text2Reader.ReadLine();

            while (lineText1 != null || lineText2 !=null)
            {
                if (lineText1 == lineText2)
                {
                    sameLines++;
                }
                else
                {
                    differentLines++;
                }
                lineText1 = text1Reader.ReadLine();
                lineText2 = text2Reader.ReadLine();
            }
        }
        Console.WriteLine("Same Lines :{0}", sameLines);
        Console.WriteLine("Different Lines: {0}", differentLines);
    }
}

