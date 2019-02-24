using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_decimal_numeric_system_to_N_numeric_system
{
    class Program
    {
        static void Main(string[] args)
        {
            var parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int number = parameters[1];
            int numericSystem = parameters[0];

            var result = new List<int>();

            while (number > 0)
            {
                int remainder = number % numericSystem;
                number /= numericSystem;
                result.Add(remainder);
            }
            result.Reverse();

            Console.WriteLine(string.Join("", result));
        }
    }
}
