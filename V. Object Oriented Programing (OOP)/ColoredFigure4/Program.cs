using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string figure = input[0];
                string colour = input[1];
                int size = int.Parse(input[2]);

                switch (figure)
                {
                    case "Circle":
                        Circle circle = new Circle(colour, size);

                        Console.WriteLine(circle.GetName());
                        Console.WriteLine(circle.Show());
                        Console.WriteLine(circle.GetArea());
                        break;

                    case "Triangle":
                        Triangle triangle = new Triangle(colour, size);

                        Console.WriteLine(triangle.GetName());
                        Console.WriteLine(triangle.Show());
                        Console.WriteLine(triangle.GetArea());
                        break;

                    case "Square":
                        Square square = new Square(colour, size);

                        Console.WriteLine(square.GetName());
                        Console.WriteLine(square.Show());
                        Console.WriteLine(square.GetArea());
                        break;
                }

            }
        }
    }
}
