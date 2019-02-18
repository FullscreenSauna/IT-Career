using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int person1 = int.Parse(Console.ReadLine());
            int person2 = int.Parse(Console.ReadLine());
            int person3 = int.Parse(Console.ReadLine());

            int minutes = 0;
            int seconds = person1 + person2 + person3;

            if (seconds >= 120)
            {
                minutes = 2;
                seconds = seconds - 120;
            }
            else if (seconds >= 60)
            {
                minutes = 1;
                seconds = seconds - 60;
            }

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
