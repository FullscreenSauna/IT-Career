using System;

namespace Largest_Sum_in_Matrix_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] originalMatrix = new int[5, 5]
            {
                {2,6,1,8,9 },
                {1,8,0,3,5 },
                {3,4,8,7,2 },
                {0,9,2,8,1 },
                {2,7,1,9,7 }
            };

            int[,] dpMatrix = new int[5, 5];

            dpMatrix[0, 0] = originalMatrix[0, 0];

            //Fill the first row with the Sum of the previous cell
            for (int i = 1; i < originalMatrix.GetLength(0); i++)
            {
                dpMatrix[0, i] = originalMatrix[0, i] + dpMatrix[0, i -1];
            }

            //Fill dpMatrix with the MaxSum of each cell's neighboors
            for (int i = 1; i < originalMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < originalMatrix.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        dpMatrix[i,j] = originalMatrix[i, j] + dpMatrix[i -1, j];
                    }
                    else
                    {
                        int firstPosibleSum = dpMatrix[i - 1, j] + originalMatrix[i, j];
                        int secondtPosibleSum = dpMatrix[i, j - 1] + originalMatrix[i, j];

                        dpMatrix[i, j] = Math.Max(firstPosibleSum, secondtPosibleSum);
                    }
                }
            }

            //Print dpMatrix
            for (int i = 0; i < dpMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < dpMatrix.GetLength(1); j++)
                {
                    Console.Write($"{dpMatrix[i,j]}, ");
                }
                Console.WriteLine();
            }

            //TODO: find the path with the highest sums in the dpMatrix
            //TODO: convert the path from dpMatrix to the originalMatrix

            Console.WriteLine();
        }
    }
}
