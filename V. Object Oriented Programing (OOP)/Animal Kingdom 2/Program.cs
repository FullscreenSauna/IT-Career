using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom_2
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = new Dog();

            Trainer trainer = new Trainer(animal);

            Console.WriteLine(trainer.Make());
        }
    }
}
