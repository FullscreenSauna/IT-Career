using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int seats = rows * columns;
            double result = 0;

            if (projection == "Premiere")
            {
                result = seats * 12.00;
            }
            else if (projection == "Normal")
            {
                result = seats * 7.50;
            }
            else if (projection == "Discount")
            {
                result = seats * 5.00;
            }

            Console.WriteLine($"{result:f2} leva");
        }
    }
}
