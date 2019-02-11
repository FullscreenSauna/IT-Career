using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_of_all_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToArray();

            Array.Sort(numbers);

            int count = 1;

            //             2 2 2 2 3 7 8 8

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{numbers[i - 1]} -> {count}");
                    count = 1;
                }

                if (i == numbers.Length -1)
                {
                    Console.WriteLine($"{numbers[i]} -> {count}");
                }
            }
        }
    }
}
