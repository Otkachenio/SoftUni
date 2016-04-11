using System;
using System.Linq;

namespace IndexOfLetters
{
    class Program
    {
        static void Main()
        {
            char[] az = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (Char)i).ToArray();
            Console.Write("Please, enter your word: ");
            string word = Console.ReadLine();
            string wordCase = word.ToUpper();
            int index = 0;
            for (int i = 0; i < wordCase.Length; i++)
            {
                for (int j = i; j < az.Length; j++)
                {
                    if (wordCase[i] == az[j])
                    {
                        index = j;
                        Console.WriteLine("Index of letter ({0}) is [{1}]", wordCase[i], index);
                    }
                }
            }
        }
    }
}
