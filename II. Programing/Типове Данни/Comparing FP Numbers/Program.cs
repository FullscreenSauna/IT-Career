using System;

namespace Comparing_FP_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double epsCheck = 0.000001;
            double epsValue = Math.Max(num1, num2) - Math.Min(num1, num2);

            if (epsValue >= epsCheck)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
