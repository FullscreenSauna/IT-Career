using System;

namespace Weather_Forecast
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long test = long.Parse(Console.ReadLine());
                string input = test.ToString();

                if (sbyte.TryParse(input, out sbyte a))
                {
                    Console.WriteLine("Sunny");
                }
                else if (int.TryParse(input, out int b))
                {
                    Console.WriteLine("Cloudy");
                }
                else
                {
                    Console.WriteLine("Windy");
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Rainy");
            }
            




        }
    }
}
