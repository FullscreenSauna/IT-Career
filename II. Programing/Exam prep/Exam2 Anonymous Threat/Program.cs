using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split(' ').ToList();

            var commandArgs = Console.ReadLine().Split(' ').ToArray();

            while (commandArgs[0] != "3:1")
            {
                if (commandArgs[0] == "merge")
                {
                    Merge(sequence, commandArgs);
                }
                else if (commandArgs[0] == "divide")
                {
                    Divide(sequence, commandArgs);
                }

                commandArgs = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(" ", sequence));
        }

        private static void Divide(List<string> sequence, string[] commandArgs)
        {
            int index = int.Parse(commandArgs[1]);
            int partitons = int.Parse(commandArgs[2]);

            var toDivide = sequence[index];
            sequence.RemoveAt(index);

            int lenghtOfSubsequences = toDivide.Length / partitons;

            int startIndex = 0;
            var listOfSubsequences = new List<string>();
            string substring = "";

            if (toDivide.Length % partitons == 0)
            {
                for (int i = 0; i < partitons; i++)
                {
                    substring = toDivide.Substring(startIndex, lenghtOfSubsequences);
                    startIndex += lenghtOfSubsequences;

                    listOfSubsequences.Add(substring);
                }
            }
            else
            {
                for (int i = 0; i < partitons; i++)
                {
                    if (i == partitons - 1)
                    {
                        substring = toDivide.Substring(startIndex);
                    }
                    else
                    {
                        substring = toDivide.Substring(startIndex, lenghtOfSubsequences);
                    }

                    startIndex += lenghtOfSubsequences;

                    listOfSubsequences.Add(substring);
                }
            }

            sequence.InsertRange(index, listOfSubsequences);
        }

        private static void Merge(List<string> sequence, string[] commandArgs)
        {
            int startIndex = int.Parse(commandArgs[1]);
            int endIndex = int.Parse(commandArgs[2]);

            if (startIndex < sequence.Count - 1)
            {
                if (endIndex > sequence.Count - 1)
                {
                    endIndex = sequence.Count;
                }

                string merged = "";
                int count = 0;

                for (int i = startIndex; i < endIndex; i++)
                {
                    merged += sequence[i];
                    count++;
                }

                sequence.RemoveRange(startIndex, count);
                sequence.Insert(startIndex, merged);
            }
        }
    }
}
