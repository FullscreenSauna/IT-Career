using System;
using System.Collections.Generic;
using System.Text;

namespace On_time_for_the_exam.Models
{
    public class TimeModel
    {
        public TimeModel(int examHour, int examMinute, int arrivalHour, int arrivalMinute)
        {
            this.ExamHour = examHour;
            this.ExamMinute = examMinute;
            this.ArrivalHour = arrivalHour;
            this.ArrivalMinute = arrivalMinute;
        }

        public int ExamHour { get; set; }
        public int ExamMinute { get; set; }
        public int ArrivalHour { get; set; }
        public int ArrivalMinute { get; set; }

        public string CalculateTardiness()
        {
            int examTime = this.ExamHour * 60 + this.ExamMinute;
            int arrivalTime = this.ArrivalHour * 60 + this.ArrivalMinute;

            int time = arrivalTime - examTime;

            StringBuilder result = new StringBuilder();

            if (time > 0) // Late
            {
                result.AppendLine("Late");

                if (time >= 60) // More than an hour Late
                {
                    int hours = time / 60;
                    int minutes = time % 60;

                    result.AppendLine($"{hours}:{minutes:d2} hours after the start");
                }
                else
                {
                    result.AppendLine($"{time} minutes after the start");
                }
            }
            else if (time <= 0 && time >= -30) // On Time
            {
                result.AppendLine("On Time");

                if (time < 0)
                {
                    result.AppendLine($"{Math.Abs(time)} minutes before the start");
                }
            }
            else // Early
            {
                result.AppendLine("Early");

                if (time < -60)
                {
                    int hours = Math.Abs(time / 60);
                    int minutes = Math.Abs(time % 60);

                    result.AppendLine($"{hours}:{minutes:d2} hours before the start");
                }
                else
                {
                    result.AppendLine($"{Math.Abs(time)} minutes before the start");
                }
            }

            return result.ToString().Trim();
        }
    }
}
