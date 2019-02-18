using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Учебна_зала
{
    class Program
    {
        static void Main(string[] args)
        {
            double hightInM = double.Parse(Console.ReadLine());
            double widhtInM = double.Parse(Console.ReadLine());

            double hight = hightInM * 100;
            double widht = (widhtInM * 100) - 100;

            double rows = Math.Floor(hight / 120);
            double seatsPerRow = Math.Floor(widht / 70);

            double seats = (rows * seatsPerRow) - 3;

            Console.WriteLine(seats);
        }
    }
}
