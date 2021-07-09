using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {

            //whole rational number
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            bool[] used = new bool[n];

            int[] temp = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
                temp[i] = i + 1;
            }

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            GeneratePermutations(0, numbers, temp, used);
            //stopwatch.Stop();
            //Console.WriteLine(stopwatch.ElapsedMilliseconds);
        }

        private static void GeneratePermutations(int index, int[] numbers, int[] temp, bool[] used)
        {
            if (index == numbers.Length)
            {
                for (int i = 0; i < temp.Length; i++)
                {
                    Console.Write(temp[i] + " ");
                }
                //Console.WriteLine(string.Join(" ", temp));
                Console.WriteLine();
            }
            else
            {
                //GeneratePermutations(index + 1, numbers);

                //for (int i = index + 1; i < numbers.Length; i++)
                //{
                //    Swap(i, index, numbers);
                //    GeneratePermutations(index + 1, numbers);
                //    Swap(i, index, numbers);
                //}

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        temp[index] = numbers[i];
                        GeneratePermutations(index + 1, numbers, temp, used);
                        used[i] = false;
                    }
                }
            }
        }

        static void Swap(int from, int to, int[] numbers)
        {
            int temp = numbers[from];
            numbers[from] = numbers[to];
            numbers[to] = temp;
        }
    }
}
