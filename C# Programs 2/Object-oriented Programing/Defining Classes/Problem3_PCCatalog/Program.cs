using System;
using System.Collections.Generic;

namespace Problem3_PCCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computersList = new List<Computer>();

            computersList.Add(new Computer("AlienPC",
                                            "Intel Xeon X5680 (6 x 3.33GHz)",
                                            300,
                                            "Nvidia 770 GTX (2GB)",
                                            260,
                                            "Dell T7500 Motherboard",
                                            120,
                                            "Dell 16GB DDR3 (2x8)",
                                            120,
                                            "Hitachi 1TB (7200 RPM)",
                                            100));

            computersList.Add(new Computer("AlienPC",
                                            "Intel Xeon X5680 (6 x 3.33GHz)",
                                            300,
                                            "Nvidia 770 GTX (2GB)",
                                            260,
                                            "Dell T7500 Motherboard",
                                            120,
                                            "Dell 16GB DDR3 (2x8)",
                                            120,
                                            "Hitachi 1TB (7200 RPM)",
                                            500));

            computersList.Add(new Computer("AlienPC",
                                            "Intel Xeon X5680 (6 x 3.33GHz)",
                                            300,
                                            "Nvidia 770 GTX (2GB)",
                                            260,
                                            "Dell T7500 Motherboard",
                                            120,
                                            "Dell 16GB DDR3 (2x8)",
                                            120,
                                            "Hitachi 1TB (7200 RPM)",
                                            10));

            computersList.Sort(delegate (Computer pc1, Computer pc2) { return pc1.Price.CompareTo(pc2.Price); });

            foreach (Computer pc in computersList)
            {
                Console.WriteLine(pc);
            }
        }
    }
}