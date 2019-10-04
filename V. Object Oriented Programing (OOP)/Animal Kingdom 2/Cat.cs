using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom_2
{
    class Cat : IAnimal
    {
        public string MakeNoise()
        {
            return "Meow!";
        }

        public string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }

        public string Perform()
        {
            return $"{MakeNoise()}\n{MakeTrick()}";
        }
    }
}
