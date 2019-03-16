using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_biggest_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).ToList();

            Console.WriteLine(string.Join(" ", numbers.Take(3)));
        }
    }
}
