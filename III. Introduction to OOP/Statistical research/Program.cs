using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statistical_research
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, Person>();

            while (n-- > 0)
            {
                var input = Console.ReadLine().Split().ToArray();

                string name = input[0];
                int age = int.Parse(input[1]);

                if (!people.ContainsKey(name))
                {
                    people.Add(name, new Person());
                }

                people[name] = new Person(name, age);
            }

            foreach (var person in people.OrderByDescending(p => p.Key))
            {
                if (person.Value.Age >= 30)
                {
                    Console.WriteLine(person.Value);
                }
            }
        }
    }
}
