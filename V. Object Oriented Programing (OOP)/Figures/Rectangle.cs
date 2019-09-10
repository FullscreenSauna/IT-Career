using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : IDrawable
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public string Draw()
        {
            return $"Drawing a Rectangle wich is {Height} high and {Width} wide";
        }
    }
}
