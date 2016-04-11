using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrixD_
{
    class Program
    {
        static void Main()
        {
            int n = 4;
            int[,] matrix = new int[n, n];
            int p = 1, c = 0;
            int n1 = n - 1, m1 = 0;

            for (int m = 0; m < n; m++)
            {
                if (m1 == m)
                {
                    for (int a = 0; a <= n1; a++)
                    {
                        matrix[a, m1] = p;
                        p++;
                        c=a;
                    }
                    m1=c;
                }
                else if (m == m1 - 1)
                {
                    for (int a = m; a >= 0; a--)
                    {
                        matrix[a, m] = p;
                        p++;
                    }
                }
                if (c == n1)
                {
                    for (int b = 1; b <= n1; b++)
                    {
                        matrix[c, b] = p;
                        p++;
                    }
                    c++;
                    n1--;
                }
                
            }

            for (int t = 0; t < n; t++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("{0,3}", matrix[t, k]);
                }
                Console.WriteLine();
            }
        }
    }
}
