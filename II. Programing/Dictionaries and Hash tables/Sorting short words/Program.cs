using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_short_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine()
                .Split(' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?')
                .Select(element => element.ToLower())
                .Where(word => word.Count() < 5 && word != "")
                .OrderBy(x => x)
                .Distinct()
                .ToList();

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
