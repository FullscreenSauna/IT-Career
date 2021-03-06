﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_and_output
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            int colsCount = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rowsCount, colsCount];

            for (int rows = 0; rows < rowsCount; rows++)
            {
                for (int cols = 0; cols < colsCount; cols++)
                {
                    matrix[rows, cols] = int.Parse(Console.ReadLine());
                }
            }

            for (int rows = 0; rows < rowsCount; rows++)
            {
                double sum = 0;
                for (int cols = 0; cols < colsCount; cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                    sum += matrix[rows, cols];
                }
                Console.WriteLine(sum / colsCount);
            }
        }
    }
}
