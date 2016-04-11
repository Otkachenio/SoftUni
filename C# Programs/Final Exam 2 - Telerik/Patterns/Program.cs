using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        string output;
        long sum = 0;
        long[,] matrix = new long[n, n];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sb.AppendLine(Console.ReadLine());
            string[] tokens = sb.ToString().Split(' ');
            sb.Clear();

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = long.Parse(tokens[j]);
            }
        }

        Program pat = new Program();
        output = pat.CheckPattern(matrix);

        if (output != "NO")
        {
            Console.WriteLine(output);
        }
        else
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            Console.WriteLine("NO " + sum);
        }
    }

    public string CheckPattern(long[,] matrix)
    {
        long a, b, c, d, e, f, g;
        long bestSum = 0;
        bool check = false;

        for (int i = 0; i <= matrix.GetLength(0) - 3; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - 5; j++)
            {
                a = matrix[i, j];
                b = matrix[i, j + 1];
                c = matrix[i, j + 2];
                d = matrix[i + 1, j + 2];
                e = matrix[i + 2, j + 2];
                f = matrix[i + 2, j + 3];
                g = matrix[i + 2, j + 4];

                if (a == (b - 1) && b == (c - 1) && c == (d - 1) && d == (e - 1) && e == (f - 1) && f == (g - 1))
                {
                    if (bestSum < (a + b + c + d + e + f + g))
                    {
                        bestSum = (a + b + c + d + e + f + g);
                        check = true;
                    }
                }
                a = b = c = d = e = f = g = 0;
            }
        }

        if (check)
        {
            return ("YES " + bestSum);
        }
        return "NO";
    }
}
