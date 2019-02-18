using System;
using System.Linq;

namespace Array_statistics
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

            Console.WriteLine($"Min = {input.Min()}");
            Console.WriteLine($"Min = {input.Max()}");
            Console.WriteLine($"Min = {input.Sum()}");
            Console.WriteLine($"Min = {input.Average()}");
        }
    }
}
