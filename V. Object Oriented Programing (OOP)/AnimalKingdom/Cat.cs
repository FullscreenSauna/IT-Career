using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    public class Cat : Animal, IMakeNoise, IMakeTrick
    {
        public Cat(int age, string name) : base(age, name)
        {
        }

        public override string MakeNoise()
        {
            return $"Meow! {base.MakeNoise()}";
        }

        public override string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }
    }
}
