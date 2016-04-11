using System;
using System.Numerics;

class NthCatalanNumber
{
    static void Main()
    {
        int n;
        Console.Write("Please, enter your number: ");
        bool checkN = true;
        do
        {
            checkN = int.TryParse(Console.ReadLine(), out n);
        } while (n < 0);

        if (checkN && n>0) 
        { 
            BigInteger fact2N = 1;
            BigInteger factNPlus1 = 1;
            BigInteger factN = 1;
            for (int i = 1; i <= n; i++)
            {
                factN *= i;
            }
            for (int k = 1; k <= 2 * n; k++)
            {
                fact2N *= k;
            }
            for (int j = 1; j <= n + 1; j++)
            {
                factNPlus1 *= j;
            }
            Console.Write("The {0} Catalan number is: ", n);
            Console.WriteLine(fact2N / (factNPlus1 * factN));
        }
        else
        {
            Console.WriteLine("ERROR: Not a valid entry, enter only positive numbers");
        }
    }
}