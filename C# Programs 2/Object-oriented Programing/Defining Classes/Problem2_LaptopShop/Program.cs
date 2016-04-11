using System;

namespace Problem2_LaptopShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop hp = new Laptop("HP 250 G2", 699.0m);
            Console.WriteLine(hp);

            Laptop lenovo = new Laptop("Lenovo Yoga 2 Pro",
                                    2259.00m,
                                    "Lenovo",
                                    "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache",
                                    8,
                                    "Intel HD Graphics 4400",
                                    "128GB SSD",
                                    "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display",
                                    "Li-Ion, 4-cells, 2550 mAh",
                                    "4.5 hours");
            Console.WriteLine(lenovo);
        }
    }
}