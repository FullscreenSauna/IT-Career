using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write("/" + new string('^', n / 2) + "\\");
            Console.Write(new string('_', (n * 2) - ((n / 2 + 2) * 2)));
            Console.WriteLine("/" + new string('^', n / 2) + "\\");

            for (int i = 0; i < n - 2; i++)
            {
                if (n > 4 && i == n - 3)
                {
                    Console.Write("|");
                    Console.Write(new string(' ', n / 2 + 1));
                    Console.Write(new string('_', (n * 2) - ((n / 2 + 2) * 2)));
                    Console.Write(new string(' ', n / 2 + 1));
                    Console.WriteLine("|");
                }
                else
                {
                    Console.Write("|");
                    Console.Write(new string(' ', (n * 2) - 2));
                    Console.WriteLine("|");
                }
            }

            Console.Write("\\" + new string('_', n / 2) + "/");
            Console.Write(new string(' ', (n * 2) - ((n / 2 + 2) * 2)));
            Console.WriteLine("\\" + new string('_', n / 2) + "/");
        }
    }
}
