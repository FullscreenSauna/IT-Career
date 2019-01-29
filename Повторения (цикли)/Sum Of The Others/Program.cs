using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Of_The_Others
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int maxNumber = 0;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > maxNumber)
                {
                    sum += maxNumber;
                    maxNumber = number;                    
                }
                else
                {
                    sum += number;
                }
            }

            if (sum == maxNumber)
            {
                Console.WriteLine("Yes, Sum = " + maxNumber);
            }
            else
            {
                Console.WriteLine("No, Diff = " + Math.Abs(maxNumber - sum));
            }
        }
    }
}
