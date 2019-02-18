using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int third = n % 10;
            int second = n / 10 % 10;
            int first = n / 100 % 10;

            int rows = first + second;
            int colums = first + third;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    if (n % 5 == 0)
                    {
                        n -= first;
                        Console.Write(n + " ");
                    }
                    else if (n % 3 == 0)
                    {
                        n -= second;
                        Console.Write(n + " ");
                    }
                    else
                    {
                        n += third;
                        Console.Write(n + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
