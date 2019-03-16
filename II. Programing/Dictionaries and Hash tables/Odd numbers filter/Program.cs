using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_numbers_filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ') .Select(int.Parse).Where(x => x % 2 == 0).ToArray();

            var list = input.Select(number =>
            {
                if (number > input.Average())
                {
                    number++;
                }
                else
                {
                    number--;
                }

                return number;
            })
            .ToList();

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
