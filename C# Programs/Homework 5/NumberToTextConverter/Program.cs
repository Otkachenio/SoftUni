using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToTextConverter
{
    class Program
    {
        static void Main()
        {
            int range, p = 0;
            string[,] numbers =
            {
                { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty",
                "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety", "hundred", "wto hundred", "three hundred",
                "four hundred", "five hundred", "six hundred", "seven hundred", "eighthunder", "ninehundred"}
            };
            Console.Write("Please, enter a number in range of [0 to 999]: ");
            bool checkRange = int.TryParse(Console.ReadLine(), out range);
            if (checkRange && range >= 0 && range <= 999)
            {
                if (range >= 0 && range <20)
                {
                    switch (range)
                    {
                        case 0:
                            Console.WriteLine("Zero");
                            break;
                        case 1:
                            Console.WriteLine("One");
                            break;
                        case 2:
                            Console.WriteLine("Two");
                            break;
                        case 3:
                            Console.WriteLine("Three");
                            break;
                        case 4:
                            Console.WriteLine("Four");
                            break;
                        case 5:
                            Console.WriteLine("Five");
                            break;
                        case 6:
                            Console.WriteLine("Six");
                            break;
                        case 7:
                            Console.WriteLine("Seven");
                            break;
                        case 8:
                            Console.WriteLine("Eight");
                            break;
                        case 9:
                            Console.WriteLine("Nine");
                            break;
                        case 10:
                            Console.WriteLine("Ten");
                            break;
                        case 11:
                            Console.WriteLine("Eleven");
                                break;
                        case 12:
                            Console.WriteLine("Twelve");
                            break;
                        case 13:
                            Console.WriteLine("Thirteen");
                            break;
                        case 14:
                            Console.WriteLine("Fourteen");
                            break;
                        case 15:
                            Console.WriteLine("Fifteen");
                            break;
                        case 16:
                            Console.WriteLine("Sixteen");
                            break;
                        case 17:
                            Console.WriteLine("Seventeen");
                            break;
                        case 18:
                            Console.WriteLine("Eighteen");
                            break;
                        case 19:
                            Console.WriteLine("Nineteen");
                            break;
                    }
                }
                if (range >=100 && range < 1000)
                {
                    if (range >= 100 && range < 200)
                    {
                        Console.Write("One Hundred ");
                        range = range - 100;
                    }
                    else if (range >= 200 && range < 300)
                    {
                        Console.Write("Two Hundred ");
                        range = range - 200;
                    }
                    else if (range >= 300 && range < 400)
                    {
                        Console.Write("Three Hundred ");
                        range = range - 300;
                    }
                    else if (range >= 400 && range < 500)
                    {
                        Console.Write("Four Hundred ");
                        range = range - 400;
                    }
                    else if (range >= 500 && range < 600)
                    {
                        Console.Write("Five Hundred ");
                        range = range - 500;
                    }
                    else if (range >= 600 && range < 700)
                    {
                        Console.Write("Six Hundred ");
                        range = range - 600;
                    }
                    else if (range >= 700 && range < 800)
                    {
                        Console.Write("Seven Hundred ");
                        range = range - 700;
                    }
                    else if (range >= 800 && range < 900)
                    {
                        Console.Write("Eight Hundred ");
                        range = range - 800;
                    }
                    else if (range >= 900 && range < 1000)
                    {
                        Console.Write("Nine Hundred ");
                        range = range - 900;
                    }
                }
                if (range >= 20 && range <100)
                {
                    if (range >= 20 && range < 30)
                    {
                        p = range - 20;
                        Console.Write("Twenty ");
                    }
                    else if (range >= 30 && range < 40)
                    {
                        p = range - 30;
                        Console.Write("Thirty ");
                    }
                    else if (range >= 40 && range < 50)
                    {
                        p = range - 40;
                        Console.Write("Fourty ");
                    }
                    else if (range >= 50 && range < 60)
                    {
                        p = range - 50;
                        Console.Write("Fifty ");
                    }
                    else if (range >= 60 && range < 70)
                    {
                        p = range - 60;
                        Console.Write("Sixty ");
                    }
                    else if (range >= 70 && range < 80)
                    {
                        p = range - 70;
                        Console.Write("Seventy ");
                    }
                    else if (range >= 80 && range < 90)
                    {
                        p = range - 80;
                        Console.Write("Eighty ");
                    }
                    else if (range >= 90 && range < 100)
                    {
                        p = range - 90;
                        Console.Write("Ninety ");
                    }
                }
                switch (p)
                {
                    case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Error, only number in range of [0 to 999]");
            }
        }
    }
}
