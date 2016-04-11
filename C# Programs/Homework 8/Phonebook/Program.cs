using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split('-');
            List<string> list = new List<string>();
            int i = 0;

            while (input[0] != "search")
            {
                list.Add(input[0] + " -> " + input[1]);
                input = Console.ReadLine().Split('-');
                i++;
            }
            string search = Console.ReadLine();
            bool found = true;

            while (search != "exit")
            {
                foreach (string phone in list)
                {
                    
                    string[] c = phone.Split();
                    if (c[0] == search)
                    {
                        Console.WriteLine(list.Find(x => x.Contains(search)));
                        found = false;
                    }
                }
                if (found)
                {
                    Console.WriteLine("Contact {0} does not exist.", search);
                }
                search = Console.ReadLine();
                found = true;
            }
        }
    }
}
