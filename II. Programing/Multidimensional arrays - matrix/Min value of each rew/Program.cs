using System;
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
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int cols = 0; cols < colsCount; cols++)
                {
                    matrix[rows, cols] = arr[cols];
                }
            }

            Console.WriteLine();

            for (int rows = 0; rows < rowsCount; rows++)
            {
                for (int cols = 0; cols < colsCount; cols++)
                {
                    Console.Write(matrix[rows, cols] + " ");
                }
                Console.WriteLine();
            }

            for (int cols = 0; cols < colsCount; cols++)
            {
                var colum = new List<int>();

                for (int rows = 0; rows < rowsCount; rows++)
                {
                    colum.Add(matrix[rows, cols]);                  
                }
                Console.Write(colum.Min() + " ");
            }

            Console.WriteLine();
        }
    }
}
