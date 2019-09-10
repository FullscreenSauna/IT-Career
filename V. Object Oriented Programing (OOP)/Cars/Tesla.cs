using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class Tesla : Car, IElectricCar
    {
        public int Battery { get; set; }

        public Tesla(string model, string colour, int battery) : base(model, colour)
        {
            Battery = battery;
        }

        protected override string Start()
        {
            return "Tesla is starting";
        }

        protected override string Stop()
        {
            return "Tesla is breaking(regeneratively)";
        }

    }
}
