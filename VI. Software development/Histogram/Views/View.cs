using Histogram.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Histogram.Views
{
    public class View
    {
        public View()
        {
            this.GetNumbers();
        }

        public HistogramModel NumbersModel { get; set; }

        public void GetNumbers()
        {
            Console.WriteLine("How many numbers?");
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            Console.WriteLine("Input numbers");
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            this.NumbersModel = new HistogramModel(numbers);
        }

        public void GetPercentages()
        {
            var percentages = new List<double>();
            percentages = this.NumbersModel.GetPercentages();

            Console.WriteLine($"{percentages[0]:f2}%");
            Console.WriteLine($"{percentages[1]:f2}%");
            Console.WriteLine($"{percentages[2]:f2}%");
            Console.WriteLine($"{percentages[3]:f2}%");
            Console.Write($"{percentages[4]:f2}%");
        }
    }
}
