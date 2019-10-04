using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Truck : IVehicle
    {
        public Truck(double fuelQuantity, double litersPerKm)
        {
            this.fuelQuantity = fuelQuantity;
            this.litersPerKm = litersPerKm + 1.6;
        }

        public double fuelQuantity { get; set; }
        public double litersPerKm { get; set; }

        public string Drive(double distance)
        {
            if (distance * litersPerKm > fuelQuantity)
            {
                return "Truck needs refueling";
            }

            fuelQuantity -= distance * litersPerKm;
            return $"Truck traveled {distance} km";
        }

        public void Refuel(double liters)
        {
            double litersAfterLoss = liters * 0.95;

            fuelQuantity += litersAfterLoss;
        }

        public override string ToString()
        {
            return $"Truck: {fuelQuantity:f2}";
        }
    }
}
