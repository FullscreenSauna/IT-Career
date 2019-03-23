using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            var squads = new Dictionary<string, List<string>>();

            var command = Console.ReadLine().Split(' ', '-', '>').Where(x => x != "").ToArray();

            while (command[0] != "Blaze" && command[1] != "it!")
            {
                string creature = command[0];
                string squadMate = command[1];

                if (creature != squadMate)
                {
                    if (!squads.ContainsKey(creature))
                    {
                        squads.Add(creature, new List<string>());
                    }

                    if (!squads[creature].Contains(squadMate))
                    {
                        squads[creature].Add(squadMate);
                    }
                }

                command = Console.ReadLine().Split(' ', '-', '>').Where(x => x != "").ToArray();
            }

            var finalSquads = new Dictionary<string, int>();

            foreach (var creature in squads)
            {
                int count = creature.Value.Count;

                foreach (var squadMate in creature.Value)
                {
                    if (squads.ContainsKey(squadMate))
                    {
                        if (squads[squadMate].Contains(creature.Key))
                        {
                            count--;
                        }
                    }
                }

                finalSquads.Add(creature.Key, count);
            }

            foreach (var pair in finalSquads.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
    }
}
