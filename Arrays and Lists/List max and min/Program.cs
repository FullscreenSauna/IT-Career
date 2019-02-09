using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_max_and_min
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToList();

            int maxValue = int.MinValue;
            int minValue = int.MaxValue;

            for (int i = 0; i < input.Count; i++)
            {
                if (maxValue <= input[i])
                {
                    maxValue = input[i];
                }

                if (minValue >= input[i])
                {
                    minValue = input[i];
                }
            }

            foreach (var number in input)
            {
                if (number == maxValue || number == minValue)
                {
                    Console.Write(number + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
