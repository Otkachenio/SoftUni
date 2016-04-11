namespace Problem2.CustomLINQExtensionMethods
{
    using System;
    using System.Linq;
    using System.Collections.Generic;   

    class Test
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine(string.Join(", ", numbers.WhereNot<int>(a => a == 4)));

            Console.WriteLine(string.Join(", ", numbers.Repeat<int>(4)));

            IEnumerable<string> stringItems = new List<string>() { "ala", "bala", "nica", "turska", "panica" };
            IEnumerable<string> suffixes = new List<string>() { "ala", "ka" };
            Console.WriteLine(string.Join(", ", stringItems.WhereEndsWith(suffixes)));
        }
    }
}