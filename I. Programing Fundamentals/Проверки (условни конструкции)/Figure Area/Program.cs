using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();

            double parameter1 = 0;
            double parameter2 = 0;

            double area = 0;

            if (type == "square" || type == "circle")
            {
                parameter1 = double.Parse(Console.ReadLine());
            }
            else if (type == "rectangle" || type == "triangle")
            {
                parameter1 = double.Parse(Console.ReadLine());
                parameter2 = double.Parse(Console.ReadLine());
            }

            if (type == "circle")
            {
                area = Math.Round(Math.PI * Math.Pow(parameter1, 2), 3);
            }
            else if (type == "rectangle")
            {
                area = Math.Round(parameter1 * parameter2, 3);
            }
            if (type == "triangle")
            {
                area = Math.Round((parameter1 * parameter2) / 2, 3);
            }
            if (type == "square")
            {
                area = Math.Round(Math.Pow(parameter1, 2), 3);
            }

            Console.WriteLine(area);
        }
    }
}
