using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public abstract class Animal : IMakeNoise, IMakeTrick
    {
        public Animal(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public int Age { get; private set; }
        public string Name { get; private set; }

        public virtual string MakeNoise()
        {
            return $"My name is {Name}. I am {Age} years old";
        }

        public virtual string MakeTrick()
        {
            return "Look at my trick!";
        }
    }
}
