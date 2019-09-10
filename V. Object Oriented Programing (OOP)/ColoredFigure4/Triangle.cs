using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure4
{
    public class Triangle : ColoredFigure
    {
        public Triangle(string colour, int size) 
            : base(colour, size)
        {
        }

        public override string GetName()
        {
            return "Triangle";
        }

        public override string GetArea()
        {
            return $"Area: {((Math.Pow(size, 2)) * Math.Sqrt(3) / 4):f2}";
        }
    }
}
