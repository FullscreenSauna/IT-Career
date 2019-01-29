using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    class Program
    {
        static void Main(string[] args)
        {
            if (examHour == hourOfArrival)
            {
                if (minuteOfArrival > examMinute)
                {
                    minuteDiff = minuteOfArrival - examMinute;

                    Console.WriteLine("Late");
                    Console.WriteLine($"{minuteDiff} minutes after the start");
                }
                else if (minuteOfArrival < examMinute)
                {
                    minuteDiff = examMinute - minuteOfArrival;

                    Console.WriteLine("Early");
                    Console.WriteLine($"{minuteDiff} minutes before the start");
                }
            }

            if (examHour != hourOfArrival)
            {
                if (minuteOfArrival > examMinute && hourOfArrival > examHour)
                {
                    hourDiff = hourOfArrival - examHour;
                    minuteDiff = minuteOfArrival - examMinute;

                    Console.WriteLine("Late");
                    if (minuteDiff == 0)
                    {
                        Console.WriteLine($"{hourDiff}:00 hours after the start");
                    }
                    else if (minuteDiff < 10)
                    {
                        Console.WriteLine($"{hourDiff}:0{minuteDiff} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hourDiff}:{minuteDiff} hours after the start");
                    }
                }
                if (minuteOfArrival < examMinute && hourOfArrival > examHour)
                {
                    hourDiff = hourOfArrival - examHour;
                    minuteDiff = examMinute - minuteOfArrival;

                    Console.WriteLine("Late");
                    if (minuteDiff == 0)
                    {
                        Console.WriteLine($"{hourDiff}:00 hours after the start");
                    }
                    else if (minuteDiff < 10)
                    {
                        Console.WriteLine($"{hourDiff}:0{minuteDiff} hours after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hourDiff}:{minuteDiff} hours after the start");
                    }
                }
                if (minuteOfArrival < examMinute && hourOfArrival < examHour)
                {
                    hourDiff = examHour - hourOfArrival;
                    minuteDiff = examMinute - minuteOfArrival;

                    Console.WriteLine("Early");
                    if (minuteDiff == 0)
                    {
                        Console.WriteLine($"{hourDiff}:00 hours before the start");
                    }
                    else if (minuteDiff < 10)
                    {
                        Console.WriteLine($"{hourDiff}:0{minuteDiff} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hourDiff}:{minuteDiff} hours before the start");
                    }
                }
                if (minuteOfArrival > examMinute && hourOfArrival < examHour)
                {
                    hourDiff = examHour - hourOfArrival;
                    minuteDiff = minuteOfArrival - examMinute;

                    Console.WriteLine("Early");
                    if (minuteDiff == 0)
                    {
                        Console.WriteLine($"{hourDiff}:00 hours before the start");
                    }
                    else if (minuteDiff < 10)
                    {
                        Console.WriteLine($"{hourDiff}:0{minuteDiff} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine($"{hourDiff}:{minuteDiff} hours before the start");
                    }
                }
            }
    }
}
