using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_rotate_and_sum
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

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int lastNumber = numbers[numbers.Length - 1];

                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                }

                numbers[0] = lastNumber;
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
