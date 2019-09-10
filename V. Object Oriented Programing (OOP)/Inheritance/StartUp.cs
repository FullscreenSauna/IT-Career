using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine(animal.Eat());

            Dog dog = new Dog();
            Console.WriteLine(dog.Eat());
            Console.WriteLine(dog.Bark());

            Cat cat = new Cat();
            Console.WriteLine(cat.Eat());
            Console.WriteLine(cat.Meow());

            Puppy puppy = new Puppy();
            Console.WriteLine(puppy.Eat());
            Console.WriteLine(puppy.Bark());
            Console.WriteLine(puppy.Weep());
        }
    }
}
