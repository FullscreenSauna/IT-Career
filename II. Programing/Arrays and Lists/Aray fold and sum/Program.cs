using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aray_fold_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Where(x => x != "")
                .Select(int.Parse)
                .ToArray();

            int[] firstPart = new int[input.Length / 4];
            int[] secondPart = new int[input.Length / 4];

            for (int i = 0; i < firstPart.Length; i++)
            {
                firstPart[i] = input[i];
            }
            Array.Reverse(firstPart);

            for (int i = secondPart.Length -1; i >= 0; i--)
            {
                secondPart[i] = input[input.Length - i - 1];
            }

            int[] secondLine = new int[input.Length / 2];

            for (int i = 0; i < secondLine.Length; i++)
            {
                if (i < secondLine.Length / 2)
                {
                    secondLine[i] = firstPart[i];
                }
                else
                {
                    secondLine[i] = secondPart[i - secondLine.Length / 2];
                }
            }

            int[] firstLine = new int[input.Length / 2];

            for (int i = 0; i < firstLine.Length; i++)
            {
                firstLine[i] = input[i + input.Length / 4];
            }

            int[] result = new int[input.Length / 2];

            for (int i = 0; i < firstLine.Length; i++)
            {
                result[i] = firstLine[i] + secondLine[i];
            }

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
