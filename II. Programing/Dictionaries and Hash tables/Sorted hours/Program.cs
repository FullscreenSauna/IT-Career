using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_hours
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = Console.ReadLine().Split(' ').ToArray();

            Console.WriteLine(string.Join(" ", hours.OrderBy(x => x)));
        }
    }
}
