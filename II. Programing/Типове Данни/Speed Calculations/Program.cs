using System;

namespace Speed_Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double miles = meters / 1609;
            double km = meters / 1000;

            double aSeconds = seconds + minutes * 60 + hours * 3600;
            double aHours = hours + minutes / 60 + seconds / 3600;

            Console.WriteLine(meters / aSeconds);
            Console.WriteLine(km / aHours);
            Console.WriteLine(miles / aHours);
            
        }
    }
}
