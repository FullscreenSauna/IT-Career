using System;

namespace Filling_Water
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                if (liters > 255 || result + liters > 255)
                {
                    Console.WriteLine("Insuficient capacity!");
                }
                else
                {
                    result += liters;
                }
            }

            Console.WriteLine(result);
        }
    }
}
