using System;
using Histogram.Controllers;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.GetPercentages();
        }
    }
}
