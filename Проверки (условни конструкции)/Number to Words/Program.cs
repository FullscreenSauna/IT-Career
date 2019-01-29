using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_to_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = int.Parse(Console.ReadLine());

            if (value == 1)
            {
                Console.WriteLine("one");
            }
            else if (value == 2)
            {
                Console.WriteLine("two");
            }
            else if (value == 3)
            {
                Console.WriteLine("three");
            }
            else if (value == 4)
            {
                Console.WriteLine("four");
            }
            else if (value == 5)
            {
                Console.WriteLine("five");
            }
            else if (value == 6)
            {
                Console.WriteLine("six");
            }
            else if (value == 7)
            {
                Console.WriteLine("seven");
            }
            else if (value == 8)
            {
                Console.WriteLine("eight");
            }
            else if (value == 9)
            {
                Console.WriteLine("nine");
            }
            else if (value >= 10)
            {
                Console.WriteLine("number too big");
            }
        }
    }
}
