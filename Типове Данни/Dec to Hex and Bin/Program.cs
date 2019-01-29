using System;

namespace Dec_to_Hex_and_Bin
{
    class Program
    {
        static void Main(string[] args)
        {
            int dec = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(dec, 16).ToUpper();
            string bin = Convert.ToString(dec, 2).ToUpper();

            Console.WriteLine(hex);
            Console.WriteLine(bin);
        }
    }
}
