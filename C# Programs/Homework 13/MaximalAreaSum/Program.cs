using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader readMatrix = new StreamReader(@"..\..\Matrix.txt");
        StreamWriter maximalSumWriter = new StreamWriter(@"..\..\Maximal Sum.txt");
        int[,] matrix;
        int rowsAndColums = 0;
        string[] matrixAsString;
        int bestSum = 0;
        int maximalSum = 0;

        using (readMatrix)
        {
            string firstRow = readMatrix.ReadLine();
            rowsAndColums = int.Parse(firstRow);
            matrix = new int[rowsAndColums,rowsAndColums];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrixAsString = readMatrix.ReadLine().Split(' ');
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(matrixAsString[j]);
                    Console.Write("{0} ", matrix[i,j]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    bestSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];

                    if (maximalSum < bestSum)
                    {
                        maximalSum = bestSum;
                    }
                    bestSum = 0;
                }
            }
        }

        Console.WriteLine($"Maximal sum: {maximalSum}");

        using (maximalSumWriter)
        {
            maximalSumWriter.Write($"{maximalSum}");
        }
    }
}

