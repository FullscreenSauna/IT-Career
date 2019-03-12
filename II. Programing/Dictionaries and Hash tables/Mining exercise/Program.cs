using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mining_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            var input = Console.ReadLine();
            int i = 0;
            string resourse = string.Empty;

            while (input != "stop")
            {
                if (i % 2 == 0)
                {
                    resourse = input;
                }
                else
                {
                    if (!dict.ContainsKey(resourse))
                    {
                        dict.Add(resourse,int.Parse(input));
                    }
                    else
                    {
                        dict[resourse] += int.Parse(input);
                    }
                }

                i++;
                input = Console.ReadLine();
            }

            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
