using System;
using On_time_for_the_exam.Controllers;

namespace On_time_for_the_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.CalculateTardiness();
        }
    }
}
