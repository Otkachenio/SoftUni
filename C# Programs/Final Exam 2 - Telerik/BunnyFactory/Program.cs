using System;
using System.Text;
using System.Collections.Generic;

class BunnyProgram
{
    static void Main()
    {
        List<ulong> cages = new List<ulong>();
        List<ulong> list = new List<ulong>();
        string input = Console.ReadLine();
        ulong number = 0;
        ulong s = 0, sum = 0;
        ulong product = 1;
        int counter = 0;
        int cageSum = 0; //Number of cages that are taken for sum
            
        while (input != "END")
        {
            number = ulong.Parse(input);
            cages.Add(number);
            input = Console.ReadLine();
        }

        while (true)
        {
            for (int i = 0; i <= counter; i++)
            {
                if ((int)s > cages.Count)
                {
                    break;
                }
                s += cages[i];
                cageSum++;
            }

            if ((int)s > cages.Count)
            {
                break;
            }

            for (int i = cageSum; i <= (int)s; i++)
            {
                product *= cages[i];
                sum += cages[i];
            }

            string sumAndProduct = sum.ToString() + product.ToString();

            foreach (var ch in sumAndProduct)
            {
                if (ch != '0' && ch != '1')
                {
                    list.Add((ulong)(ch - '0'));
                }
            }

            for (int i = (int)s + 1; i < cages.Count; i++)
            {
                if (cages[i] > 1)
                {
                    list.Add(cages[i]);
                }
            }

            cages = new List<ulong>(list);
            list.Clear();
            sumAndProduct = "";
            product = 1;
            sum = 0;
            cageSum = 0;
            counter++;
            s = 1;
        }

        foreach (var item in cages)
        {
            Console.Write(item + " ");
        }
    }
}