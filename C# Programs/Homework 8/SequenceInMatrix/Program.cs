using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceInMatrix
{
    class Program
    {
        static void Main()
        {
            //int rows = int.Parse(Console.ReadLine());
            //int columns = int.Parse(Console.ReadLine());
            //string[,] matrix = new string[rows, columns];

            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    string[] tokens = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            //    for (int column = 0; column < matrix.GetLength(1); column++)
            //    {
            //        matrix[row, column] = tokens[column];
            //    }
            //}
            //PrintMatrix(matrix);

            string[,] matrix =
            {
                    { "ha", "fifi", "ho", "hi" },
                    { "fo", "ha", "hi", "xx" },
                    { "xxx", "ho", "ha", "xx" }
                };

            int bestRow = 0, bestColumn = 0;
            int sum = 1, bestSum = 0;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int a = 0; a <matrix.GetLength(0); a++)
                {
                    for (int b = 0; b <matrix.GetLength(1) - 1; b++)
                    {
                        if (matrix[a,b] == matrix[a,b + 1])
                        {
                            sum++;
                            if (sum > bestSum)
                            {
                                bestRow = a;
                                bestColumn = b;
                                bestSum = sum;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    sum = 1;
                }

                for (int a = 0; a < matrix.GetLength(0) - 1; a++)
                {
                    for (int b = 0; b < matrix.GetLength(1); b++)
                    {
                        if (matrix[a,b] == matrix[a + 1,b])
                        {
                            sum++;
                            if (sum > bestSum)
                            {
                                bestRow = a;
                                bestColumn = b;
                                bestSum = sum;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    sum = 1;
                }

                for (int a = 0; a < matrix.GetLength(0) -1; a++)
                {
                    for (int b = 0; b < matrix.GetLength(1) - 1; b++)
                    {
                        if (matrix[a,b] == matrix[a+1, b+1])
                        {
                            if (a < matrix.GetLength(0) - 2)
                            {
                                a++;
                            }
                            sum++;
                            if (sum > bestSum)
                            {
                                bestRow = a;
                                bestColumn = b;
                                bestSum = sum;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    sum = 1;
                }
            }
            Console.WriteLine("Best Row = {0}, Best Column = {1}", bestRow, bestColumn);
            Console.WriteLine("Best sum = {0}", bestSum);
            for (int a = 0; a<bestSum; a++)
            {
                Console.Write($"{matrix[bestRow, bestColumn]} ".PadLeft(2, ' '));
            }
            Console.WriteLine(); 
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int pr = 0; pr < matrix.GetLength(0); pr++)
            {
                for (int pc = 0; pc < matrix.GetLength(1); pc++)
                {
                    Console.Write($"{matrix[pr, pc]} ".PadLeft(2, ' '));
                }
                Console.WriteLine();
            }
        }
    }
}
