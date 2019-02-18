using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_even_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            foreach (var number in input)
            {
                if (number % 2 == 0)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
