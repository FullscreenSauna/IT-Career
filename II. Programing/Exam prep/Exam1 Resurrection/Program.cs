using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            short numberOfPhoenixes = short.Parse(Console.ReadLine());

            Console.WriteLine($"{numberOfPhoenixes} phoenixes:");

            for (int i = 1; i <= numberOfPhoenixes; i++)
            {
                Console.WriteLine($"P{i}");

                int bodyLength = int.Parse(Console.ReadLine());
                Console.WriteLine($"Body Lenght: {bodyLength}");

                decimal bodyWidth = decimal.Parse(Console.ReadLine());
                Console.WriteLine($"Body Width: {bodyWidth}");

                int wingLength = int.Parse(Console.ReadLine());
                Console.WriteLine($"Length of 1 wing: {wingLength}");

                decimal totalYears = bodyLength * bodyLength * (bodyWidth + 2 * wingLength);
                Console.WriteLine($"Total years: {bodyLength} ^ 2 * ({bodyWidth} + 2 * {wingLength}) = {totalYears}");
            }
        }
    }
}
