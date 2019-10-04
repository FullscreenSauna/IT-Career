using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    interface IVehicle
    {
        double fuelQuantity { get; set; }

        double litersPerKm { get; set; }

        string Drive(double distance);

        void Refuel(double liters);
    }
}
