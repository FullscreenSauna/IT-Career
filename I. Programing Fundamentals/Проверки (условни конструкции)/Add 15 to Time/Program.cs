using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_15_to_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            int minute2 = minute + 15;

            if (minute2 > 59)
            {
                hour += 1;
                minute2 -= 60;
            }

            if (hour > 23)
            {
                hour = 0;
            }

            if (minute2 < 10)
            {
                Console.WriteLine($"{hour}:0{minute2}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minute2}");
            }
           
        }
    }
}
