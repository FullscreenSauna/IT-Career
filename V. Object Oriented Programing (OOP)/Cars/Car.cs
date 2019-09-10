using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public abstract class Car
    {
        protected string Model { get; set; }
        protected string Colour { get; set; }

        protected Car(string model, string colour)
        {
            Model = model;
            Colour = colour;
        }

        protected abstract string Start();
        protected abstract string Stop();
    }
}
