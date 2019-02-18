using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_reversed_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToArray();

            var reversedNumbers = new List<int>();
            string newNumber = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNumber = input[i];

                while (currentNumber != 0)
                {
                    newNumber += currentNumber % 10;
                    currentNumber = currentNumber / 10;
                }

                reversedNumbers.Add(int.Parse(newNumber));
                newNumber = string.Empty;
            }

            Console.WriteLine(reversedNumbers.Sum());
        }
    }
}
