using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_to_single_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Where(x => x != "")
                .Select(int.Parse)
                .ToArray();

            while (numbers.Length > 1)
            {
                int[] condensed = new int[numbers.Length - 1];
                for (int j = 0; j < condensed.Length; j++)
                {
                    condensed[j] = numbers[j] + numbers[j + 1];
                }
                numbers = condensed;
            }
              


            Console.WriteLine(numbers[0]);
        }
    }
}
