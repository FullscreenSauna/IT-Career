using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var jewelsPrice = prices[0];
            var goldPrice = prices[1];

            int earnings = 0;
            int cost = 0;

            while (true)
            {
                var heist = Console.ReadLine().Split(' ').ToArray();

                if (heist[0] == "Jail" && heist[1] == "Time")
                {
                    break;
                }

                var treasure = heist[0].ToCharArray();

                cost += int.Parse(heist[1]);

                foreach (var item in treasure)
                {
                    if (item == '%')
                    {
                        earnings += jewelsPrice;
                    }
                    else if (item == '$')
                    {
                        earnings += goldPrice;
                    }
                }
            }

            int profit = Math.Abs(earnings - cost);

            if (earnings >= cost)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {profit}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {profit}.");
            }
        }
    }
}
