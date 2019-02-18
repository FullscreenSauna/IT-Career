using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Take_and_go
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var number = int.Parse(Console.ReadLine());

            if (!input.Contains(number))
            {
                Console.WriteLine("No occurences were found!");
            }
            else
            {
                int index = Array.LastIndexOf(input, number);
                int sum = 0;

                for (int i = 0; i < index; i++)
                {
                    sum += input[i];
                }

                Console.WriteLine(sum);
            }
        }
    }
}
