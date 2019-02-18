using System;

namespace Beers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string biggestType = string.Empty;
            long biggestVolume = long.MinValue;

            for (int i = 0; i < n; i++)
            {               
                string type = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * height;

                if (volume > biggestVolume)
                {
                    biggestVolume = (long)volume;
                    biggestType = type;
                }
            }

            Console.WriteLine();
            Console.WriteLine(biggestType);
        }
    }
}
