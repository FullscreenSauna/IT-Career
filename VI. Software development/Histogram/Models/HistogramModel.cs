using System;
using System.Collections.Generic;
using System.Text;

namespace Histogram.Models
{
    public class HistogramModel
    {
        public HistogramModel(List<int> numbers)
        {
            this.Numbers = new List<int>(numbers);
        }

        public List<int> Numbers { get; set; }

        public List<double> GetPercentages()
        {
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            foreach (var number in this.Numbers)
            {
                if (number < 200)
                {
                    p1++;
                }
                else if (number < 400)
                {
                    p2++;
                }
                else if (number < 600)
                {
                    p3++;
                }
                else if (number < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }
            }

            p1 = p1 / this.Numbers.Count * 100;
            p2 = p2 / this.Numbers.Count * 100;
            p3 = p3 / this.Numbers.Count * 100;
            p4 = p4 / this.Numbers.Count * 100;
            p5 = p5 / this.Numbers.Count * 100;

            return new List<double> { p1, p2, p3, p4, p5 };
        }
    }
}
