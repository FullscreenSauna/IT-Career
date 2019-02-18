using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int plantationSize = int.Parse(Console.ReadLine());
            double yield = double.Parse(Console.ReadLine());
            int wineNeeded = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrapes = plantationSize * yield;
            double wine = 0.4 * totalGrapes / 2.5;

            if (wine >= wineNeeded)
            {
                double wineLeft = Math.Ceiling(wine - wineNeeded);
                double winePerPerson = Math.Ceiling(wineLeft / workers);

                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{wineLeft} liters left -> {winePerPerson} liters per person.");
            }
            else
            {
                double wineDefficit = Math.Floor(wineNeeded - wine);

                Console.WriteLine($"It will be a tough winter! More {wineDefficit} liters wine needed.");
            }

        }
    }
}
