using System;
using System.Collections.Generic;
using System.Numerics;

class Program
{
    static void Main()
    {
        string[] NxMcellsInput = Console.ReadLine().Split(' ');
        int X = int.Parse(NxMcellsInput[0]);
        int Y = int.Parse(NxMcellsInput[1]);

        string[] foodCordinatesInput = Console.ReadLine().Split(' ');
        int foodX = int.Parse(foodCordinatesInput[0]);
        int foodY = int.Parse(foodCordinatesInput[1]);

        int numberOfEnemies = int.Parse(Console.ReadLine());
        List<string> enemiesCordinates = new List<string>();
        BigInteger[,] matrix = new BigInteger[X,Y];

        for (int i = 0; i < numberOfEnemies; i++)
        {
            enemiesCordinates.Add(Console.ReadLine());
        }
        string[] enemieCordinatesAsString;
        int enemieX = 0, enemieY = 0;

        for (int i = 0; i < enemiesCordinates.Count; i++)
        {
            enemieCordinatesAsString = enemiesCordinates[i].Split(' ');
            enemieX = int.Parse(enemieCordinatesAsString[0]);
            enemieY = int.Parse(enemieCordinatesAsString[1]);
            matrix[enemieX, enemieY] = -1;
        }
        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                if (x == 0 && y == 0)
                {
                    matrix[x, y] = 1;
                    continue;
                }

                if (x == 0)
                {
                    matrix[0, y] = matrix[0, y - 1];
                    continue;
                }

                if (y == 0)
                {
                    matrix[x, 0] = matrix[x - 1, 0];
                    continue;
                }

                if (matrix[x,y] == -1)
                {
                    matrix[x, y] = 0;
                    continue;
                }

                matrix[x, y] = matrix[x - 1, y] + matrix[x, y -1];
            }
        }
        Console.WriteLine(matrix[foodX, foodY]);
    }
}