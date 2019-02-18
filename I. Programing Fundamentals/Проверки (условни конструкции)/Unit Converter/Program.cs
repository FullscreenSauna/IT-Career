using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var cFrom = Console.ReadLine().ToLower();
            var cTo = Console.ReadLine().ToLower();

            double meters = 0;
            double print = 0;

            if (cFrom == "m")
            {
                meters = value ;
            }
            else if (cFrom == "mi")
            {
                meters = value / 0.000621371192;
            }
            else if (cFrom == "mm")
            {
                meters = value / 1000;
            }
            else if (cFrom == "cm")
            {
                meters = value / 100;
            }
            else if (cFrom == "in")
            {
                meters = value / 39.3700787;
            }
            else if (cFrom == "km")
            {
                meters = value / 0.001;
            }
            else if (cFrom == "ft")
            {
                meters = value / 3.2808399;
            }
            else if (cFrom == "yd")
            {
                meters = value / 1.0936133;
            }

            if (cTo == "m")
            {
                print = meters;
            }
            else if (cTo == "mi")
            {
                print = meters * 0.000621371192;
            }
            else if (cTo == "mm")
            {
                print = meters * 1000;
            }
            else if (cTo == "cm")
            {
                print = meters * 100;
            }
            else if (cTo == "in")
            {
                print = meters * 39.3700787;
            }
            else if (cTo == "km")
            {
                print = meters * 0.001;
            }
            else if (cTo == "ft")
            {
                print = meters * 3.2808399;
            }
            else if (cTo == "yd")
            {
                print = meters * 1.0936133;
            }

            Console.WriteLine($"{print} {cTo}");
        }
    }
}
