using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rowsCount = input[0];
            int colsCount = input[1];

            var lotteryTicket = CreateLotteryTicket(rowsCount, colsCount);

            bool isWinning = CheckLotteryTicket(rowsCount, colsCount, lotteryTicket);

            if (isWinning)
            {
                Console.WriteLine("YES");

                double prizeAmount = CalculatePrize(rowsCount, colsCount, lotteryTicket);

                Console.WriteLine($"The amount of money won is: {prizeAmount:f2}");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }

        private static double CalculatePrize(int rowsCount, int colsCount, int[,] lotteryTicket)
        {
            int sumBellowDiagonal = 0;
            sumBellowDiagonal = SumBellowDiagonal(colsCount, lotteryTicket, sumBellowDiagonal);

            int sumEvenOnDiagonal = 0;
            sumEvenOnDiagonal = SumEvenOnDiagonal(colsCount, lotteryTicket, sumEvenOnDiagonal);

            int sumOuterRows = 0;
            sumOuterRows = SumOuterRows(rowsCount, colsCount, lotteryTicket, sumOuterRows);

            int sumOuterCols = 0;
            sumOuterCols = SumOuterCols(rowsCount, colsCount, lotteryTicket, sumOuterCols);

            double prizeAmount = (sumBellowDiagonal + sumEvenOnDiagonal + sumOuterRows + sumOuterCols) / 4;

            return prizeAmount;
        }

        private static int SumOuterCols(int rowsCount, int colsCount, int[,] lotteryTicket, int sumOuterCols)
        {
            for (int i = 0; i < rowsCount; i++)
            {
                if (lotteryTicket[i, 0] % 2 != 0)
                {
                    sumOuterCols += lotteryTicket[i, 0];
                }
            }

            for (int i = 0; i < rowsCount; i++)
            {
                if (lotteryTicket[i, colsCount - 1] % 2 != 0)
                {
                    sumOuterCols += lotteryTicket[i, colsCount - 1];
                }
            }

            return sumOuterCols;
        }

        private static int SumOuterRows(int rowsCount, int colsCount, int[,] lotteryTicket, int sumOuterRows)
        {
            for (int i = 0; i < colsCount; i++)
            {
                if (lotteryTicket[0, i] % 2 == 0)
                {
                    sumOuterRows += lotteryTicket[0, i];
                }
            }

            for (int i = 0; i < colsCount; i++)
            {
                if (lotteryTicket[rowsCount - 1, i] % 2 == 0)
                {
                    sumOuterRows += lotteryTicket[rowsCount - 1, i];
                }
            }

            return sumOuterRows;
        }

        private static int SumEvenOnDiagonal(int colsCount, int[,] lotteryTicket, int sumEvenOnDiagonal)
        {
            for (int i = 0; i < colsCount; i++)
            {
                if (lotteryTicket[i, i] % 2 == 0)
                {
                    sumEvenOnDiagonal += lotteryTicket[i, i];
                }
            }

            return sumEvenOnDiagonal;
        }

        private static int SumBellowDiagonal(int colsCount, int[,] lotteryTicket, int sumBellowDiagonal)
        {
            for (int i = 1; i < colsCount; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    sumBellowDiagonal += lotteryTicket[i, j];
                }
            }

            return sumBellowDiagonal;
        }

        private static int[,] CreateLotteryTicket(int rowsCount, int colsCount)
        {
            var lotteryTicket = new int[rowsCount, colsCount];

            for (int rows = 0; rows < rowsCount; rows++)
            {
                int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                for (int cols = 0; cols < colsCount; cols++)
                {
                    lotteryTicket[rows, cols] = arr[cols];
                }
            }

            return lotteryTicket;
        }

        private static bool CheckLotteryTicket(int rowsCount, int colsCount, int[,] lotteryTicket)
        {
            int sumOfMainDiagonal = 0;
            int sumAboveDiagonal = 0;
            int sumBellowDiagonal = 0;

            for (int i = 0; i < rowsCount; i++)
            {
                sumOfMainDiagonal += lotteryTicket[i, i];

                if (i < rowsCount - 1)
                {
                    for (int j = i + 1; j < colsCount; j++)
                    {
                        sumAboveDiagonal += lotteryTicket[i, j];
                    }
                }

                if (i > 0)
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        sumBellowDiagonal += lotteryTicket[i, j];
                    }
                }
            }

            int sumOfSecondaryDiagonal = 0;
            for (int i = rowsCount - 1; i >= 0; i--)
            {
                sumOfSecondaryDiagonal += lotteryTicket[i, i];
            }

            bool diagonalCheck = sumOfMainDiagonal == sumOfSecondaryDiagonal;
            bool aboveDiagonalCheck = sumAboveDiagonal % 2 == 0;
            bool bellowDiagonalCheck = sumBellowDiagonal % 2 != 0;

            bool isWinning = false;

            if (diagonalCheck && aboveDiagonalCheck && bellowDiagonalCheck)
            {
                isWinning = true;
            }

            return isWinning;
        }
    }
}
