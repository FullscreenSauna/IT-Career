using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom
{
    class Dog : Animal
    {
        public Dog(int age, string name) : base(age, name)
        {
        }

        public override string MakeNoise()
        {
            return $"Woof! {base.MakeNoise()}";
        }

        public override string MakeTrick()
        {
            return "Hold my paw, human!";
        }
    }
}
