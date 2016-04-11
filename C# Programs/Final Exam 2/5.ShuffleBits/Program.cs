using System;
using System.Text;

class Program
{
    static void Main()
    {
        uint firstNumber = uint.Parse(Console.ReadLine());
        uint secondNumber = uint.Parse(Console.ReadLine());
        StringBuilder finalNumberBits = new StringBuilder();

        if (firstNumber >= secondNumber)
        {
            string firstNumberBits = Convert.ToString(firstNumber, 2).PadLeft(32, '0');
            string secondNumberBits = Convert.ToString(secondNumber, 2).PadLeft(32, '0');

            for (int i = 0; i < 32; i++)
            {
                finalNumberBits.Append(firstNumberBits[i]);
                finalNumberBits.Append(secondNumberBits[i]);
            }

        }
        else
        {
            string firstNumberBits = Convert.ToString(firstNumber, 2).PadLeft(32, '0');
            string secondNumberBits = Convert.ToString(secondNumber, 2).PadLeft(32, '0');

           

            for (int i = 0; i < 32; i += 2)
            {
                finalNumberBits.Append(firstNumberBits[i]);
                finalNumberBits.Append(firstNumberBits[i + 1]);
                finalNumberBits.Append(secondNumberBits[i]);
                finalNumberBits.Append(secondNumberBits[i + 1]); 
            }
        }
        string final = finalNumberBits.ToString();
        ulong finalNumber = Convert.ToUInt64(final, 2);

        Console.WriteLine(finalNumber);
    }
}