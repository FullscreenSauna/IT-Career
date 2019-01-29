using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < n; i++)
            {
                if (i %2 == 0)
                {
                    evenSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    oddSum += int.Parse(Console.ReadLine());
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes, sum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(oddSum - evenSum));
            }
        }
    }
}
