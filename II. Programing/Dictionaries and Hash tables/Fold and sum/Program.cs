using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = input.Count() / 4;

            var upperRow1 = input.Take(k).Reverse().ToArray();
            var upperRow2 = input.Skip(k * 3).Reverse().ToArray();

            var upperRow = upperRow1.Concat(upperRow2).ToArray();
            var lowerRow = input.Skip(k).Take(2 * k).ToArray();

            var result = upperRow.Select((x, index) => x + lowerRow[index]);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
