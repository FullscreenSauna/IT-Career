using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure4
{
    public abstract class ColoredFigure
    {
        protected string colour;
        protected int size;

        public ColoredFigure(string colour, int size)
        {
            this.colour = colour;
            this.size = size;
        }

        public string Show()
        {
            return $"Colour: {colour} \nSize: {size}";
        }

        public abstract string GetName();
        public abstract string GetArea();
    }
}
