using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToList();

            var command = Console.ReadLine();

            while (command != "print")
            {
                var commandArgs = command.Split(' ');
                var checkCommand = commandArgs[0];

                switch (checkCommand)
                {
                    case "add":
                        int insertPosition = int.Parse(commandArgs[1]);
                        int insertValue = int.Parse(commandArgs[2]);

                        numbers.Insert(insertPosition, insertValue);
                        break;

                    case "addMany":
                        insertPosition = int.Parse(commandArgs[1]);
                        var numbersToInsert = new List<int>();

                        for (int i = 2; i < commandArgs.Count(); i++)
                        {
                            numbersToInsert.Add(int.Parse(commandArgs[i]));
                        }

                        numbers.InsertRange(insertPosition, numbersToInsert);
                        break;

                    case "contains":
                        int searchedNumber = int.Parse(commandArgs[1]);

                        Console.WriteLine(numbers.IndexOf(searchedNumber));
                        break;

                    case "remove":
                        int index = int.Parse(commandArgs[1]);

                        numbers.RemoveAt(index);
                        break;

                    case "shift":
                        int numberOfRotations = int.Parse(commandArgs[1]);

                        for (int i = 0; i < numberOfRotations; i++)
                        {
                            int lastNumber = numbers[numbers.Count - 1];

                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1]; 
                            }

                            numbers[0] = lastNumber;
                        }
                        break;

                    case "sumPairs":
                        for (int i = 0; i < numbers.Count - 1; i++)
                        {
                            numbers[i] += numbers[i + 1];
                            numbers.RemoveAt(i + 1);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[ {string.Join(", ", numbers)} ]");
        }
    }
}
