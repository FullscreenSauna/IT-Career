using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car___drive_method
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            var cars = new Dictionary<string, Car>();

            while (numberOfCars-- > 0)
            {
                var carInfo = Console.ReadLine().Split().ToArray();

                string model = carInfo[0];
                double fuel = double.Parse(carInfo[1]);
                double mileage = double.Parse(carInfo[2]);

                cars.Add(model, new Car(model, fuel, mileage));
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                var commandArgs = command.Split();

                string model = commandArgs[1];
                int kilimeters = int.Parse(commandArgs[2]);

                if (cars.ContainsKey(model))
                {
                    cars[model].Drive(kilimeters);
                }
            }

            cars.ToList().ForEach(c => Console.WriteLine(c.Value));
        }
    }
}
