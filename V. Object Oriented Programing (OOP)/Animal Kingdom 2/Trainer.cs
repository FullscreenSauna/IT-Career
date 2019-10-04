using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom_2
{
    class Trainer
    {
        private IAnimal animal;

        public Trainer(IAnimal animal)
        {
            this.animal = animal;
        }

        public string Make()
        {
           return animal.Perform();
        }
    }
}
