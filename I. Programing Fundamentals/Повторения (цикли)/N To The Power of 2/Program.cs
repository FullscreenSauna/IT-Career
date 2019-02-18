using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_To_The_Power_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(num);

                num = num * 2;
            }
        }
    }
}
