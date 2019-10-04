using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carMetricks = Console.ReadLine().Split();
            double fuelQuantity = double.Parse(carMetricks[1]);
            double litersPerKm = double.Parse(carMetricks[2]);

            Car car = new Car(fuelQuantity, litersPerKm);

            string[] truckMetricks = Console.ReadLine().Split();
            fuelQuantity = double.Parse(truckMetricks[1]);
            litersPerKm = double.Parse(truckMetricks[2]);

            Truck truck = new Truck(fuelQuantity, litersPerKm);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                switch (command[0])
                {
                    case "Drive":
                        if (command[1] == "Car")
                        {
                            Console.WriteLine(car.Drive(double.Parse(command[2])));
                        }
                        else
                        {
                            Console.WriteLine(truck.Drive(double.Parse(command[2])));
                        }
                        break;

                    case "Refuel":
                        if (command[1] == "Car")
                        {
                            car.Refuel(double.Parse(command[2]));
                        }
                        else
                        {
                            truck.Refuel(double.Parse(command[2]));
                        }
                        break;
                }
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
