using System;
using System.Collections.Generic;
using System.Text;
using On_time_for_the_exam.Models;

namespace On_time_for_the_exam.Views
{
    public class View
    {
        public View()
        {
            GetTime();
        }

        public TimeModel Time { get; set; }

        private void GetTime()
        {
            Console.WriteLine("Hour of the exam:");
            int examHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Minute of the exam:");
            int examMinute = int.Parse(Console.ReadLine());
            Console.WriteLine("Hour of arrival:");
            int arrivalHour = int.Parse(Console.ReadLine());
            Console.WriteLine("Minute of arrival:");
            int arrivalMinute = int.Parse(Console.ReadLine());

            this.Time = new TimeModel(examHour, examMinute, arrivalHour, arrivalMinute);
        }

        public string CalculateTardiness()
        {
           return this.Time.CalculateTardiness();
        }
    }
}
