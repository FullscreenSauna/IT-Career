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

            int oldSum = int.MinValue;
            int diff = 0;
            int result = 0;

            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                int sum = num1 + num2;

                if (i != 0)
                {
                    diff = oldSum - sum; 

                    if (diff != 0)
                    {
                        result = Math.Abs(diff);
                    }
                }

                oldSum = sum;
            }

            if (diff != 0)
            {
                Console.WriteLine("No, maxdiff= " + result);
            }
            else
            {
                Console.WriteLine("Yes, value= " + oldSum);
            }

        }
    }
}
