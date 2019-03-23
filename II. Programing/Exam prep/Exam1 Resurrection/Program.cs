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

            for (int i = 1; i <= numberOfPhoenixes; i++)
            {
                long bodyLength = long.Parse(Console.ReadLine());

                decimal bodyWidth = decimal.Parse(Console.ReadLine());

                long wingLength = long.Parse(Console.ReadLine());

                decimal totalYears = bodyLength * bodyLength * (bodyWidth + 2 * wingLength);
                Console.WriteLine($"{totalYears}");
            }
        }
    }
}
