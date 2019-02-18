using System;

namespace Perimeter__Area_and_Diagonal_of__a_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(2 * a + 2 * b);
            Console.WriteLine(a * b);
            Console.WriteLine(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
    }
}
