using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_number_of_occrrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split(' ');

            var dict = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!dict.ContainsKey(word))
                {
                    dict[word] = 1;
                }
                else
                {
                    dict[word]++;
                }
            }

            var results = new List<string>();

            foreach (var pair in dict)
            {
                if (pair.Value % 2 != 0)
                {
                    results.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
