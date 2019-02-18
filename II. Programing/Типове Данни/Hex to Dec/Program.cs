using System;

namespace Hex_to_Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine().ToLower();

            int dec = Convert.ToInt32(hex, 16);

            Console.WriteLine(dec);
        }
    }
}
