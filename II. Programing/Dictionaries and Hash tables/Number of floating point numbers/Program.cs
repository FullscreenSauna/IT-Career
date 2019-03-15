using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_of_floating_point_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            var numbersDict = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!numbersDict.ContainsKey(number))
                {
                    numbersDict.Add(number, 1);
                }
                else
                {
                    numbersDict[number]++;
                }
            }

            foreach (var pair in numbersDict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
