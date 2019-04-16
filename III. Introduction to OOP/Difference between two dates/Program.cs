using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_between_two_dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            var test = new DateModifier(firstDate, secondDate);

            Console.WriteLine(test.Calculate());
        }
    }
}
