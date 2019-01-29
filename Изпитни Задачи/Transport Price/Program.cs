using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            double price = 0;

            if (distance < 20)
            {
                switch (dayTime)
                {
                    case "day":
                        price = 0.7 + (distance * 0.79);
                        break;
                    case "night":
                        price = 0.7 + (distance * 0.90);
                        break;
                }
            }
            else if (distance < 100)
            {
                price = distance * 0.09;
            }
            else
            {
                price = distance * 0.06;
            }

            Console.WriteLine(price);
        }
    }
}
