using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_edit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine()
                .Split(' ')
                .ToArray();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();

                if (command == "Reverse")
                {
                    Array.Reverse(inputArr);
                }

                if (command == "Distinct")
                {
                    inputArr = inputArr.Distinct().ToArray();
                }

                if (command.Contains("Replace"))
                {
                    string[] replaceCommand = command.Split(' ').ToArray();
                    int index = int.Parse(replaceCommand[1]);
                    string replaceWord = replaceCommand[2];

                    inputArr[index] = replaceWord;
                }
            }

            Console.WriteLine(string.Join(", ", inputArr));
        }
    }
}
