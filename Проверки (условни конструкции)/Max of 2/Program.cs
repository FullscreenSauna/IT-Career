using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());

            //var max = Math.Max(num1, num2);

            Console.WriteLine(Math.Max(num1, num2));
        }
    }
}
