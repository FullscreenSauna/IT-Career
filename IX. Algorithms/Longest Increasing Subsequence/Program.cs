using System;

namespace Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduce Stack structure to replace currentLenght
            var sequence = new int[] { 3, 14, 5, 12, 15, 7, 8, 9, 11, 10, 13, 2, 4 };

            var lenght = new int[sequence.Length];

            int currentHighestNumer = 0;
            int currentLenght = 0;

            int iterations = 0;

            for (int i = 0; i < sequence.Length; i++)
            {

                if (sequence[i] > currentHighestNumer)
                {
                    currentHighestNumer = sequence[i];
                    lenght[i] = ++currentLenght;
                }
                else
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (sequence[j] <= sequence[i])
                        {
                            currentHighestNumer = sequence[i];
                            lenght[i] = ++currentLenght;
                            break;
                        }
                        currentLenght--;
                    }
                }
            }

            Console.WriteLine(iterations);
        }
    }
}
