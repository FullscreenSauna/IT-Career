using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double pricePerKgVegetables = double.Parse(Console.ReadLine());
            double pricePerKgFruits = double.Parse(Console.ReadLine());
            int vegetablesKg = int.Parse(Console.ReadLine());
            int fruitsKg = int.Parse(Console.ReadLine());

            double vegetablesPrice = pricePerKgVegetables * vegetablesKg;
            double fruitsPrice = pricePerKgFruits * fruitsKg;

            double priceInBGN = vegetablesPrice + fruitsPrice;
            double priceInEUR = priceInBGN / 1.94;

            Console.WriteLine($"{priceInEUR:f2}");
        }
    }
}
