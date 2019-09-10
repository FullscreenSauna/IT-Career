using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : IDrawable
    {
        public int Radius { get; private set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public string Draw()
        {
            return $"Drawing circle with a radius of: {Radius}";
        }
    }
}
