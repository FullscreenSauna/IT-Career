using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Digits_of_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int number = 0;

            while (n > 0)
            {
                number += n % 10;
                n /= 10;
            }

            Console.WriteLine(number);
        }
    }
}
