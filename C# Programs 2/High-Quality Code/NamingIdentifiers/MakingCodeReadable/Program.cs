using System;

namespace ConsoleApplication1
{
    public class ProductMatrix
    {
        public static void Main()
        {
            double[,] firstMatrix = new double[,] { { 1, 3 }, { 5, 7 } };
            double[,] secondMatrix = new double[,] { { 4, 2 }, { 1, 5 } };
            double[,] productMatrix = MultiplyMatrixes(firstMatrix, secondMatrix);

            for (int i = 0; i < productMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < productMatrix.GetLength(1); j++)
                {
                    Console.Write(productMatrix[i, j] + " ");
                }

                Console.WriteLine();
            }
        }

        public static double[,] MultiplyMatrixes(double[,] fristMatrix, double[,] secondMatrix)
        {
            if (fristMatrix.GetLength(1) != secondMatrix.GetLength(0))
            {
                throw new Exception("The matrix must be square sized!");
            }

            var productMatrix = new double[fristMatrix.GetLength(0), secondMatrix.GetLength(1)];

            for (int productRows = 0; productRows < productMatrix.GetLength(0); productRows++)
            {
                for (int productCols = 0; productCols < productMatrix.GetLength(1); productCols++)
                {
                    for (int firstmatrix = 0; firstmatrix < fristMatrix.GetLength(1); firstmatrix++)
                    {
                        productMatrix[productRows, productCols] += 
                                                        fristMatrix[productRows, firstmatrix] *
                                                        secondMatrix[firstmatrix, productCols];
                    }    
                }    
            }
                
            return productMatrix;
        }
    }
}