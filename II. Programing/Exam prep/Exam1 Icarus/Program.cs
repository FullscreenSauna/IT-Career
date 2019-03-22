using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int index = int.Parse(Console.ReadLine());
            int damage = 1;
            var commandArgs = Console.ReadLine().Split(' ').ToArray();

            while (commandArgs[0] != "Supernova")
            {
                string dirrection = commandArgs[0];
                int steps = int.Parse(commandArgs[1]);

                if (dirrection == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        index--;
                        if (index == -1)
                        {
                            index = sequence.Length - 1;
                            damage++;
                        }
                        sequence[index] -= damage;
                    }
                }
                else if (dirrection == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        index++;
                        if (index > sequence.Length - 1)
                        {
                            index = 0;
                            damage++;
                        }
                        sequence[index] -= damage;
                    }
                }

                commandArgs = Console.ReadLine().Split(' ').ToArray();
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
