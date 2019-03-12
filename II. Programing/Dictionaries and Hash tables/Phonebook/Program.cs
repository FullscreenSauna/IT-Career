using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandArgs = Console.ReadLine().Split(' ');

            var phonebook = new Dictionary<string, string>();
            var outputs = new List<string>();

            while (commandArgs[0] != "END")
            {
                string name = commandArgs[1];

                if (commandArgs[0] == "A")
                {
                    string number = commandArgs[2];

                    phonebook[name] = number;
                }
                else if (commandArgs[0] == "S")
                {
                    if (phonebook.ContainsKey(name))
                    {
                        outputs.Add($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        outputs.Add($"Contact {name} does not exist.");
                    }
                }

                commandArgs = Console.ReadLine().Split(' ');
            }

            Console.WriteLine();

            foreach (var output in outputs)
            {
                Console.WriteLine(output);
            }
        }
    }
}
