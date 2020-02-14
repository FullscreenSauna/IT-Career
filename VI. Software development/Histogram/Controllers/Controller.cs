using System;
using System.Collections.Generic;
using System.Text;
using Histogram.Models;
using Histogram.Views;

namespace Histogram.Controllers
{
    public class Controller
    {
        public Controller()
        {
            this.View = new View();
            this.Histogram = this.View.NumbersModel;
        }

        public HistogramModel Histogram { get; set; }
        public View View { get; set; }

        public void GetPercentages()
        {
            this.View.GetPercentages();
        }
    }
}
