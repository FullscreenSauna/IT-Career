using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : IVehicle
    {
        public Car(double fuelQuantity, double litersPerKm)
        {
            this.fuelQuantity = fuelQuantity;
            this.litersPerKm = litersPerKm + 0.9;
        }

        public double fuelQuantity { get; set; }
        public double litersPerKm { get; set; }

        public string Drive(double distance)
        {
            if (distance * litersPerKm > fuelQuantity)
            {
                return "Car needs refueling";
            }

            fuelQuantity -= distance * litersPerKm;
            return $"Car traveled {distance} km";
        }

        public void Refuel(double liters)
        {
            fuelQuantity += liters;
        }

        public override string ToString()
        {
            return $"Car: {fuelQuantity:f2}";
        }
    }
}
