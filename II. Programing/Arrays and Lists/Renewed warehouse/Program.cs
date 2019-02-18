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
            var products = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();            
            var quantity = Console.ReadLine().Split(' ').Where(x => x != "").Select(long.Parse).ToArray();
            var price = Console.ReadLine().Split(' ').Where(x => x != "").Select(double.Parse).ToArray();

            for (int i = 1; i > 0;)
            {
                var input = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();

                if (input.Contains("done"))
                {
                    break;
                }
                else
                {
                    string product = input[0];
                    int request = int.Parse(input[1]);

                    int index = Array.IndexOf(products, product);

                    if (index > quantity.Length - 1)
                    {
                        Console.WriteLine($"We don't have enough {product}");
                    }
                    else
                    {
                        if (request > quantity[index])
                        {
                            Console.WriteLine($"We don't have enough {product}");
                        }
                        else
                        {
                            Console.WriteLine($"{product} x {request} costs {request * price[index]:f2}");
                            quantity[index] -= request;
                        }                    
                    }
                }
            }
        }
    }
}
