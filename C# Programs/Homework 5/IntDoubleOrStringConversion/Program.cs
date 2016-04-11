using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace IntDoubleOrStringConversion
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            double d = 0;
            int i = 0;
            string str;
            byte entryType;
            Console.Write("Please, enter your data: ");
            str = Console.ReadLine();
            bool isDouble = double.TryParse(str, out d);
            if (isDouble)
            {
                if (d % 1 == 0)
                {
                    i = (int)d;
                    entryType = 1;//Integer entry
                }
                else
                {
                    entryType = 2;//Double entry
                }
            }
            else
            {
                entryType = 3;//String entry
            }
            switch (entryType)
            {
                case 1: Console.WriteLine("Integer input. The output is:{0}", i + 1); break;
                case 2: Console.WriteLine("Double input. The output is:{0}", d + 1); break;
                case 3: Console.WriteLine("String input. The output is:{0}", str + "*"); break;
            }
        }
    }
}