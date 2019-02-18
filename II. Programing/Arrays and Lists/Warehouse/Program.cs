using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            var quantity = Console.ReadLine().Split(' ').Where(x => x != "").Select(long.Parse).ToArray();
            var price = Console.ReadLine().Split(' ').Where(x => x != "").Select(double.Parse).ToArray();

            for (int i = 1; i > 0;)
            {
                string input = Console.ReadLine();

                if (input == "done")
                {
                    break;
                }
                else
                {
                    int index = Array.IndexOf(product, input);

                    Console.WriteLine($"{product[index]} costs: {price[index]}; Available quantity: {quantity[index]}");
                }
            }
        }
    }
}
