using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Trainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string command;

            var trainers = new Dictionary<string, Trainer>();

            while ((command = Console.ReadLine()) != "Tournament")
            {
                var info = command.Split().ToArray();

                string trainerName = info[0];

                string pokemonName = info[1];
                string type = info[2];
                int health = int.Parse(info[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName));
                }
         
                trainers[trainerName].Pokemons.Add(new Pokemon(pokemonName, type, health));
            }

            while ((command = Console.ReadLine()) != "End")
            {
                foreach (var trainer in trainers)
                {
                    trainer.Value.Battle(command);
                }
            }

            trainers.Values.OrderByDescending(t => t.Badges).ToList().ForEach(t => Console.WriteLine(t));
        }
    }
}
