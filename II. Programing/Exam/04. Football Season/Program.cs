using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Football_Season
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new SortedDictionary<string, List<int>>();

            var input = Console.ReadLine().Split('-').Where(x => x != "").ToArray();

            while (string.Join(" ", input) != "End of season")
            {
                string player = input[0];
                int goals = int.Parse(input[1]);

                if (!players.ContainsKey(player))
                {
                    players.Add(player, new List<int>());
                }

                players[player].Add(goals);

                input = Console.ReadLine().Split('-').Where(x => x != "").ToArray(); ;
            }

            foreach (var pair in players)
            {
                int totalGoals = pair.Value.Sum();

                Console.WriteLine($"{pair.Key}-> {totalGoals}");
            }
        }
    }
}
