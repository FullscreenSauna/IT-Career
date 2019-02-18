using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza_products
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split(' ').ToArray();
            int lenght = int.Parse(Console.ReadLine());

            var finalProducts = new List<string>();
            int count = 0;

            for (int i = 0; i < products.Length; i++)
            {
                string product = products[i];

                if (product.Length == lenght)
                {
                    Console.WriteLine($"Adding {product}");
                    finalProducts.Add(product);
                    count++;
                }

                if (finalProducts.Count == 10)
                {
                    break;
                }
            }

            Console.WriteLine($"Made pizza with a total of {count} ingredients.");
            Console.WriteLine($"The ingredients are {string.Join(", ", finalProducts)}");
        }
    }
}
