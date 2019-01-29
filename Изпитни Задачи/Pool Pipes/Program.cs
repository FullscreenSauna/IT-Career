using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int maxP1 = int.Parse(Console.ReadLine());
            int maxP2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipe1 = maxP1 * hours;
            double pipe2 = maxP2 * hours;
            double bothPipes = pipe1 + pipe2;

            if (bothPipes <= volume)
            {
                double percentFilled = Math.Floor(bothPipes / volume * 100);
                double pipeOneContribution = Math.Floor(pipe1 / bothPipes * 100);
                double pipeTwoContribution = Math.Floor(pipe2 / bothPipes * 100);

                Console.WriteLine($"The pool is {percentFilled}% full. Pipe 1: {pipeOneContribution}%. Pipe 2: {pipeTwoContribution}%");
            }
            else
            {
                double overflow = bothPipes - volume;

                Console.WriteLine($"For {hours} hours the pool overflows with {overflow} liters.");
            }
        }
    }
}
