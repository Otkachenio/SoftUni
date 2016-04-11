using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter your first word: ");
            string firstWord = Console.ReadLine();
            Console.Write("Please, enter you second word: ");
            string secondWord = Console.ReadLine();
            Console.WriteLine("------------");
            if (firstWord.Length < secondWord.Length)
            {
                Console.WriteLine("First word({0}) is first", firstWord);
            }
            else if (firstWord.Length == secondWord.Length)
            {
                Console.WriteLine("The two words ({0}) and ({1}) are equal", firstWord, secondWord);
            }
            else
            {
                Console.WriteLine("Second work ({0}) is first", secondWord);
            }
        }
    }
}
