using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            //Varian C)
            int n = 4;
            int[,] matrix = new int[n,n];
            int p = 1;
            int r = 0;
            int c = 1;
            for (int i = n; i >= 0; i--)
            {
                r = i - 1;
                if (r >= 0)
                {
                    for (int a = 0; a < c; a++)
                    {
                        matrix[r, a] = p;
                        p++;
                        r++;
                        if (r >= n)
                        {
                            break;
                        }
                    }
                }
                c++;
            }
            c = 0;
            for (int i = 0; i < n; i++)
            {
                
                r = 0;
                for (int a = 1; a < n; a++)
                {
                    a += c;
                    if (a >= n)
                    {
                        break;
                    }
                    matrix[r, a] = p;
                    r++;
                    p++;
                    a -= c;
                }
                c++;
            }

            for (int t = 0; t< n; t++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.Write("{0,3}", matrix[t,k]);
                }
                Console.WriteLine();
            }    
        }
    }
}
