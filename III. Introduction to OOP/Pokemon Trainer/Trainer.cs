using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pokemon_Trainer
{
    class Trainer
    {
        private string name;
        private List<Pokemon> pokemons;
        private int badges;

        public Trainer() { }

        public Trainer(string name)
        {
            Name = name;
            pokemons = new List<Pokemon>();
        }

        public string Name { get => name; private set => name = value; }
        public int Badges { get => badges; private set => badges = value; }
        internal List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }

        public void Battle(string type)
        {
            if (pokemons.Any(p => p.Type == type))
            {
                badges++;
            }
            else
            {
                pokemons.ForEach(p => p.TakeDamage());
            }

            pokemons.RemoveAll(p => !p.IsAlive);
        }

        public override string ToString()
        {
            return $"{name} {badges} {pokemons.Count}";
        }
    }
}
