using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double dailySalary = double.Parse(Console.ReadLine());
            double usdCourse = double.Parse(Console.ReadLine());

            double monthlySalary = workDays * dailySalary;
            double yearlySalary = (monthlySalary * 12) + (monthlySalary * 2.5);

            double tax = yearlySalary * 0.25;
            double pureYearlyProfit = (yearlySalary - tax) * usdCourse;

            double dailyProfit = Math.Round(pureYearlyProfit / 365, 2);

            Console.WriteLine(dailyProfit);
        }
    }
}
