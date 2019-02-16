using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Changing_a_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "Odd" && command != "Even")
            {
                var commandArgs = command.Split(' ');

                if (commandArgs[0] == "Delete")
                {
                    int numberToDel = int.Parse(commandArgs[1]);

                    numbers.RemoveAll(x => x == numberToDel);
                }
                else if (commandArgs[0] == "Insert")
                {
                    int insertValue = int.Parse(commandArgs[1]);
                    int insertPos = int.Parse(commandArgs[2]);

                    numbers.Insert(insertPos, insertValue);
                }

                command = Console.ReadLine();
            }

            if (command == "Even")
            {
                numbers.RemoveAll(x => x % 2 != 0);
            }
            else if (command == "Odd")
            {
                numbers.RemoveAll(x => x % 2 == 0);
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
