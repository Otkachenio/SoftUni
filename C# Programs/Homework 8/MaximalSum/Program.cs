using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please, enter how many rows and colum you want: ");
            string[] rowsAndCols = Console.ReadLine().Split(' ');
            int rows = int.Parse(rowsAndCols[0]);
            int cols = int.Parse(rowsAndCols[1]);
            int[,] matrix = new int[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] currentRowNumbersAsStrings =
                            Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(currentRowNumbersAsStrings[col]);
                }
            }
            int bestSum = 0;
            int bestRow = 0;
            int bestCol = 0;
            int sum = 0;
           
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int a = 0; a < rows - 2; a++)
                {
                    for (int b = 0; b < cols - 2; b++)
                    {
                        sum = matrix[a, b] + matrix[a, b + 1] + matrix[a, b + 2] +
                            matrix[a + 1, b] + matrix[a + 1, b + 1] + matrix[a + 1, b + 2] +
                            matrix[a + 2, b] + matrix[a + 2, b + 1] + matrix[a + 2, b + 2];
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            bestRow = a;
                            bestCol = b;
                        }
                    }
                }
            }

            Console.WriteLine("Sum = " + bestSum);
            for (int br = bestRow; br < bestRow + 3; br++)
            {
                for (int bc = bestCol; bc < bestCol + 3; bc++)
                {
                    Console.Write("{0,3}", matrix[br,bc]);
                }
                Console.WriteLine();
            }
        }
    }
}
