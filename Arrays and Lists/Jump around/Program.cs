using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jump_around
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int index = 0;
            int sum = 0;

            while (true)
            {
                sum += numbers[index];

                int step = numbers[index];

                if (index + step < numbers.Length)
                {
                    index += step;
                }
                else if (index - step >= 0)
                {
                    index -= step;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
