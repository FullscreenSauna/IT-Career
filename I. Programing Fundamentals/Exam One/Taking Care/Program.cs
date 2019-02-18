using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taking_Care
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodBought = int.Parse(Console.ReadLine()) * 1000;
            int days = int.Parse(Console.ReadLine());

            int gramsEaten = 0;

            for (int i = 0; i < days; i++)
            {
                gramsEaten += int.Parse(Console.ReadLine());
            }

            if (foodBought >= gramsEaten)
            {
                int leftovers = foodBought - gramsEaten;

                Console.WriteLine($"Food is enough! Leftovers: {leftovers} grams.");
            }
            else
            {
                int foodNeeded = gramsEaten - foodBought;

                Console.WriteLine($"Food is not enough. You need {foodNeeded} grams more.");
            }
        }
    }
}
