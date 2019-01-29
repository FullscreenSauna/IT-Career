using System;

namespace Imperial_to_Metric
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            switch (type)
            {
                case "miles":
                    Console.WriteLine($"{value} {type} = {value * 1.6:f2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{value} {type} = {value * 2.54:f2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{value} {type} = {value * 30:f2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{value} {type} = {value * 0.91:f2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{value} {type} = {value * 3.8:f2} liters");
                    break;
            }
        }
    }
}
