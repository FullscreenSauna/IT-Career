using System;

namespace ASCII_symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());

            for ( ; start <= finish; start++)
            {
                Console.Write((char)start + " ");
            }
            Console.WriteLine();
        }
    }
}
