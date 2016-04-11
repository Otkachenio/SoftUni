using System;
using System.Collections.Generic;

namespace Problem1.School
{
    class School
    {
        static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();

            Student pesho = new Student("Pesho", 10);
            Student gosho = new Student("Gosho", 5);

            dict.Add(pesho.ClassNumber, pesho.Name);
            dict.Add(gosho.ClassNumber, gosho.Name);

            foreach (KeyValuePair<int, string> kvp in dict)
            {
                Console.WriteLine(kvp.Value + " number: " + kvp.Key);
            }
        }
    }
}
