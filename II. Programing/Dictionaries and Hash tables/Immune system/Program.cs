using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immune_system
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = int.Parse(Console.ReadLine());
            string virus = Console.ReadLine();

            var defeatedViruses = new List<string>();

            int originalHealth = health;

            while (virus != "end")
            {
                int virusPower = 0;

                foreach (var ellement in virus)
                {
                    virusPower += ellement;
                }

                virusPower /= 3;
                int timeToKill = 0;

                if (!defeatedViruses.Contains(virus))
                {
                    timeToKill = virusPower * virus.Length;

                    defeatedViruses.Add(virus);
                }
                else
                {
                    timeToKill = virusPower * virus.Length / 3;
                }

                Console.WriteLine($"Virus {virus}: {virusPower} => {timeToKill} seconds");

                health -= timeToKill;

                if (health < 1)
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }
                else
                {
                    int minutes = timeToKill / 60;
                    int seconds = timeToKill - minutes * 60;

                    Console.WriteLine($"{virus} defeated in: {minutes}m {seconds}s");
                    Console.WriteLine($"Remaining health: {health}");

                    health += (int)(health * 0.2);

                    if (health > originalHealth)
                    {
                        health = originalHealth;
                    }
                }

                virus = Console.ReadLine();
            }

            if (health > 0)
            {
                Console.WriteLine($"Final Health: {health}");
            }
        }
    }
}
