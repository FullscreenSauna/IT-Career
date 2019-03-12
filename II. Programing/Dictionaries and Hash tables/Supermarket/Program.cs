using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock = FillStock();

            Console.WriteLine();

            PrintResult(stock);
        }

        private static void PrintResult(Dictionary<string, List<double>> stock)
        {
            double grandTotal = 0;

            foreach (var pair in stock)
            {
                double result = pair.Value[0] * pair.Value[1];

                Console.WriteLine($"{pair.Key}: ${pair.Value[0]:f2} * {pair.Value[1]} = ${result:f2}");

                grandTotal += result;
            }

            Console.WriteLine(new string('-', 30));

            Console.WriteLine($"Grand Total: ${grandTotal:f2}");
        }

        private static Dictionary<string, List<double>> FillStock()
        {
            var stock = new Dictionary<string, List<double>>();

            var commandArgs = Console.ReadLine().Split(' ');

            while (commandArgs[0] != "stocked")
            {
                string product = commandArgs[0];
                double price = double.Parse(commandArgs[1]);
                double quantity = double.Parse(commandArgs[2]);


                if (!stock.ContainsKey(product))
                {
                    var properties = new List<double>
                    {
                        price,
                        quantity
                    };

                    stock.Add(product, properties);
                }
                else
                {
                    stock[product][0] = price;
                    stock[product][1] += quantity;
                }

                commandArgs = Console.ReadLine().Split(' ');
            }

            return stock;
        }
    }
}
