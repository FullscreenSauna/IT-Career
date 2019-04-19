using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Pokemon_Trainer
{
    class Pokemon
    {
        private string name;
        private string type;
        private int health;
        private bool isAlive;

        public Pokemon(string name, string type, int health)
        {
            Name = name;
            Type = type;
            Health = health;
            IsAlive = true;
        }

        public string Name { get => name; private set => name = value; }
        public string Type { get => type; private set => type = value; }
        public int Health { get => health; private set => health = value; }
        public bool IsAlive { get => isAlive; private set => isAlive = value; }

        public void TakeDamage()
        {
            health -= 10;

            if (health <= 0)
            {
                isAlive = false;
            }
        }
    }
}
