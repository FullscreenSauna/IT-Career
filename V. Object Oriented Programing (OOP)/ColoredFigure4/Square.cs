using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigure4
{
    public class Square : ColoredFigure
    {
        public Square(string colour, int size) 
            : base(colour, size)
        {
        }

        public override string GetArea()
        {
            return $"Area: {Math.Pow(size, 2):f2}";
        }

        public override string GetName()
        {
            return "Square";
        }
    }
}
