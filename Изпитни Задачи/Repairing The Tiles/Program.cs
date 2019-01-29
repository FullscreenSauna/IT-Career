using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repairing_The_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtOfSquare = int.Parse(Console.ReadLine());
            double widthOfTile = double.Parse(Console.ReadLine());
            double hightOfTile = double.Parse(Console.ReadLine());
            int widthOfBench = int.Parse(Console.ReadLine());
            int hightOfBench = int.Parse(Console.ReadLine());

            double totalArea = lenghtOfSquare * lenghtOfSquare;
            double benchArea = widthOfBench * hightOfBench;
            double areaToCover = totalArea - benchArea;

            double areaOfTile = widthOfTile * hightOfTile;

            double tilesNeeded = areaToCover / areaOfTile;
            double timeNeeded = tilesNeeded * 0.2;

            Console.WriteLine(tilesNeeded);
            Console.WriteLine(timeNeeded);
        }
    }
}
