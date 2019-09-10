using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Seat : Car
    {
        public Seat(string model, string colour) : base(model, colour)
        {
        }

        protected override string Start()
        {
            return "Seat is starting";
        }

        protected override string Stop()
        {
            return "Seat is breaking";
        }
    }
}
