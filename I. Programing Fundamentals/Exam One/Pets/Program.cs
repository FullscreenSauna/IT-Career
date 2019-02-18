using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOut = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double foodPerDay1 = double.Parse(Console.ReadLine());
            double foodPerDay2 = double.Parse(Console.ReadLine());

            var foodForCat1 = daysOut * foodPerDay1;
            var foodForCat2 = daysOut * foodPerDay2;
            var totalFood = foodForCat1 + foodForCat2;

            if (totalFood <= food)
            {
                var foodLeft = Math.Ceiling(food - totalFood);

                Console.WriteLine("The cats are well fed.");
                Console.WriteLine($"{foodLeft} kilos of food left.");
            }
            else
            {
                var foodNeeded = Math.Floor(totalFood - food);

                Console.WriteLine("The cats are hungry.");
                Console.WriteLine($"{foodNeeded} more kilos of food are needed.");
            }
        }
    }
}
