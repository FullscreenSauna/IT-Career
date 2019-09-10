using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure4
{
    class Circle : ColoredFigure
    {
        public Circle(string colour, int size) 
            : base(colour, size)
        {
        }

        public override string GetArea()
        {
            return $"Area: {Math.PI * Math.Pow(size, 2):f2}";
        }

        public override string GetName()
        {
            return "Circle:";
        }
    }
}
