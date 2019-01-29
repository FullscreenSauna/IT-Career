using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_to_100_Ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i < 998; i+= 10)
            {
                Console.WriteLine(i);
            }
        }
    }
}
