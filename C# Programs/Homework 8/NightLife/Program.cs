using System;
using System.Collections.Generic;

namespace NightLife
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, SortedDictionary<string, SortedSet<string>>> performances =
                new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] data = input.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                string city = data[0];
                string venue = data[1];
                string performar = data[2];

                if (!performances.ContainsKey(city))
                {
                    performances[city] = new SortedDictionary<string, SortedSet<string>>();
                }

                if (!performances[city].ContainsKey(venue))
                {
                    performances[city][venue] = new SortedSet<string>();
                }

                if (!performances[city][venue].Contains(performar))
                {
                    performances[city][venue].Add(performar);
                }

                input = Console.ReadLine();
            }

            foreach (var citieVenue in performances)
            {
                Console.WriteLine($"\r\n{citieVenue.Key}");

                foreach (var venueWithPerformers in citieVenue.Value)
                {
                    Console.WriteLine("->{0}: {1}", venueWithPerformers.Key, string.Join(", ", venueWithPerformers.Value));
                }
            }
        }
    }
}
