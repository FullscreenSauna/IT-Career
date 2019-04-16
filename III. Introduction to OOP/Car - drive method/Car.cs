using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Car___drive_method
{
    class Car
    {
        private string model;
        private double fuel;
        private double mileage;
        private int distanceTraveled;

        public Car() { }

        public Car(string model, double fuel, double mileage)
        {
            Model = model;
            Fuel = fuel;
            Mileage = mileage;
            DistanceTraveled = 0;
        }

        public string Model { get => model; set => model = value; }
        public double Fuel { get => fuel; set => fuel = value; }
        public double Mileage { get => mileage; set => mileage = value; }
        public int DistanceTraveled { get => distanceTraveled; private set => distanceTraveled = value; }

        public bool Drive(int amount)
        {
            double fuelConsumed = amount * mileage;

            if (fuel >= fuelConsumed)
            {
                DistanceTraveled += amount;
                Fuel -= fuelConsumed;
                return true;
            }

            Console.WriteLine("Insufficient fuel for the drive");
            return false;
        }

        public override string ToString()
        {
            return $"{Model} {Fuel:f2} {DistanceTraveled}";
        }
    }
}
