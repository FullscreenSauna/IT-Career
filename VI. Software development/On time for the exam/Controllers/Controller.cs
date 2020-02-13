using System;
using System.Collections.Generic;
using System.Text;
using On_time_for_the_exam.Models;
using On_time_for_the_exam.Views;

namespace On_time_for_the_exam.Controllers
{
    public class Controller
    {
        public Controller()
        {
            this.View = new View();
            this.Time = this.View.Time;
        }

        public TimeModel Time { get; set; }
        public View View { get; set; }

        public string CalculateTardiness()
        {
            return this.View.CalculateTardiness();
        }
    }
}
