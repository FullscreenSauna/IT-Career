using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int studentTime = hourOfArrival * 60 + minuteOfArrival;

            int minuteDiff = studentTime - examTime;

            if (minuteDiff < -30)
            {
                Console.WriteLine("Early");
            }
            else if (minuteDiff <= 0)
            {
                Console.WriteLine("On time");
            }
            else
            {
                Console.WriteLine("Late");
            }

            if (minuteDiff != 0)
            {
                int hours = Math.Abs(minuteDiff / 60);
                int minutes = Math.Abs(minuteDiff % 60);

                if (hours > 0)
                {
                    if (minutes == 0)
                    {
                        Console.Write($"{hours}:00 hours");
                    }
                    else if (minutes < 10)
                    {
                        Console.Write($"{hours}:0{minutes} hours");
                    }
                    else
                    {
                        Console.Write($"{hours}:{minutes} hours");
                    }             
                }
                else
                {
                    Console.Write(minutes + " minutes");
                }

                if (minuteDiff < 0)
                {
                    Console.WriteLine(" before the start");
                }
                else
                {
                    Console.WriteLine(" after the start");
                }
            }
        }
    }
}
