using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_class_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            person1.Name = "Pesho";
            person1.Age = 16;

            person1.IntroduceYourself();
        }
    }
}
