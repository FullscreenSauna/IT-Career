using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_Skiing
{
    class Program
    {
        static void Main(string[] args)
        {
            int skiers = int.Parse(Console.ReadLine());
            int jakets = int.Parse(Console.ReadLine());
            int helmets = int.Parse(Console.ReadLine());
            int shoes = int.Parse(Console.ReadLine());

            int jaketPrice = 120;
            int helmetPrice = 75;
            double shoePrice = 299.90;

            int jaketsTotal = jaketPrice * jakets;
            int helmetsTotal = helmetPrice * helmets;
            double shoesTotal = shoePrice * shoes;

            double totalPriceForOne = jaketsTotal + helmetsTotal + shoesTotal;
            double totalPrice = totalPriceForOne * skiers;

            double result = (totalPrice * 0.2) + totalPrice;

            Console.WriteLine($"{result:f2}");
        }
    }
}
