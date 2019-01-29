using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());

            var workDays = 365 - holidays;

            var playTime = holidays * 127 + workDays * 63;

            var hours = 0;
            var minutes = 0;
            var normDiff = 0;

            if (playTime < 30000)
            {
                normDiff = 30000 - playTime;
                hours = normDiff / 60;
                minutes = normDiff - (hours * 60);

                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
            else
            {
                normDiff = playTime - 30000;
                hours = normDiff / 60;
                minutes = normDiff - (hours * 60);

                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
        }
    }
}
