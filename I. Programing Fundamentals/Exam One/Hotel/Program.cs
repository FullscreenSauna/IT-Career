using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int nights = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine().ToLower();

            int apartmentPrice = 70;
            int presidentPrice = 125;

            double result = 0;

            if (roomType == "apartment")
            {
                result = apartmentPrice * nights;
                if (nights < 10)
                {
                    result -= result * 0.3;
                }
                else if (nights > 15)
                {
                    result -= result * 0.5;
                }
                else
                {
                    result -= result * 0.35;
                }
            }
            else if (roomType == "president apartment")
            {
                result = presidentPrice * nights;               
                if (nights < 10)
                {
                    result -= result * 0.1;
                }
                else if (nights > 15)
                {
                    result -= result * 0.2;
                }
                else
                {
                    result -= result * 0.15;
                }
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
