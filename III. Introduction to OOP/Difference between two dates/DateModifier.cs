using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Difference_between_two_dates
{
    class DateModifier
    {
        private string firstDate;
        private string secondDate;

        public DateModifier(string firstDate, string secondDate)
        {
            FirstDate = firstDate;
            SecondDate = secondDate;
        }

        public string FirstDate { get => firstDate; set => firstDate = value; }
        public string SecondDate { get => secondDate; set => secondDate = value; }

        public int Calculate()
        {
            var date1 = firstDate.Split().ToArray();

            int year1 = int.Parse(date1[0]);
            int month1 = int.Parse(date1[1]);
            int day1 = int.Parse(date1[2]);

            DateTime first = new DateTime(year1, month1, day1);

            var date2 = secondDate.Split().ToArray();

            int year2 = int.Parse(date2[0]);
            int month2 = int.Parse(date2[1]);
            int day2 = int.Parse(date2[2]);

            DateTime second = new DateTime(year2, month2, day2);

            int days = Math.Abs((first - second).Days);

            return days;
        }
    }
}
