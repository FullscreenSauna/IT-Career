using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    class Pair
    {
        public int First { get; set; }
        public int Last { get; set; }
        public bool IsCombined { get;  set; }


        public Pair(int first, int last)
        {
            First = first;
            Last = last;
        }

        public int Difference()
        {
            return Math.Abs(First - Last);
        }

        public override string ToString()
        {
            return $"({First}, {Last})";
        }
    }
}
