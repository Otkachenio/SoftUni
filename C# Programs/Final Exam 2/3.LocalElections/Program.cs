using System;

class Program
{
    static void Main()
    {
        int candidatesNum = int.Parse(Console.ReadLine());
        int electorVote = int.Parse(Console.ReadLine());
        string voteSymbol = Console.ReadLine().ToUpper();

        for (int i = 0; i < candidatesNum; i++)
        {
            Console.WriteLine(".............");
            Console.WriteLine("...+-----+...");

            if (voteSymbol == "X" && electorVote == i + 1)
            {
                Console.WriteLine("...|.\\./.|...");
                if (i < 9) Console.Write("0");
                Console.WriteLine("{0}.|..X..|...", i + 1);
                Console.WriteLine("...|./.\\.|...");
            }
            else if ((voteSymbol == "V" && electorVote == i + 1))
            {
                Console.WriteLine("...|\\.../|...");
                if (i < 9) Console.Write("0");
                Console.WriteLine("{0}.|.\\./.|...", i + 1);
                Console.WriteLine("...|..V..|...");
            }
            else
            {
                Console.WriteLine("...|.....|...");
                if (i < 9) Console.Write("0");
                Console.WriteLine("{0}.|.....|...", i + 1);
                Console.WriteLine("...|.....|...");
            }

            Console.WriteLine("...+-----+...");
        }
        Console.WriteLine(".............");
    }
}