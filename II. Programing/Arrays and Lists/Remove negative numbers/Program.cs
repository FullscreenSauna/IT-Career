using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_negative_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToList();

            int i = 0;

            while (numbers.Any(x => x < 0))
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(numbers[i]);
                }
                i++;
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
