using System;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            Console.Write($"{centuries} centuries = ");

            int years = centuries * 100;
            Console.Write($"{years} years = ");

            uint days = (uint)(years * 365.2422);
            Console.Write($"{days} days = ");

            uint hours = days * 24;
            Console.Write($"{hours} hours = ");

            long minutes = hours * 60;
            Console.Write($"{minutes} minutes = ");

            long seconds = minutes * 60;
            Console.Write($"{seconds} seconds = ");

            ulong miliseconds = (ulong)seconds * 1000;
            Console.Write($"{miliseconds} miliseconds = ");

            ulong microseconds = miliseconds * 1000;
            Console.Write($"{microseconds} microseconds = ");

            ulong nanoseconds = microseconds * 1000;
            Console.WriteLine($"{nanoseconds} nanoseconds");
        }
    }
}
