using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_the_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string day = string.Empty;

            if (!(number >= 1 && number <= 7))
            {
                day = "Error";
            }
            else
            {
                if (number == 1)
                {
                    day = "Monday";
                }
                else if (number == 2)
                {
                    day = "Tuesday";
                }
                else if (number == 3)
                {
                    day = "Wednesday";
                }
                else if (number == 4)
                {
                    day = "Thursday";
                }
                else if (number == 5)
                {
                    day = "Friday";
                }
                else if (number == 6)
                {
                    day = "Saturday";
                }
                else if (number == 7)
                {
                    day = "Sunday";
                }
            }

            Console.WriteLine(day);
        }
    }
}
