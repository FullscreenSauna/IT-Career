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

            var phonebook = new SortedDictionary<string, string>();
            var outputs = new List<string>();

            while (commandArgs[0] != "END")
            {
                if (commandArgs[0] == "A")
                {
                    string name = commandArgs[1];
                    string number = commandArgs[2];

                    phonebook[name] = number;
                }
                else if (commandArgs[0] == "S")
                {
                    string name = commandArgs[1];

                    if (phonebook.ContainsKey(name))
                    {
                        outputs.Add($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        outputs.Add($"Contact {name} does not exist.");
                    }
                }
                else if (commandArgs[0] == "ListAll")
                {
                    Console.WriteLine();

                    foreach (var pair in phonebook)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value}");
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
