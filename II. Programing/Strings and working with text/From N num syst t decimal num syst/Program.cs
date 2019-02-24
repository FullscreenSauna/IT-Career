using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace From_N_num_syst_t_decimal_num_syst
{
    class Program
    {
        static void Main(string[] args)
        {
            var parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int number = parameters[1];
            int numericSystem = parameters[0];

            var result = new List<double>();

            int power = 0;

            while (number > 0)
            {
                int currentNumber = number % 10;

                result.Add(currentNumber * Math.Pow(numericSystem, power));
                power++;

                number /= 10;
            }

            Console.WriteLine(result.Sum());
        }
    }
}
