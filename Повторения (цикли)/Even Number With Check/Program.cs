using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Number_With_Check
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {              
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());
                    if (n % 2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The number is not even");
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Invalid Number!");
                }
            }
            while (true);
            

            Console.WriteLine("Even number entered " + n);
        }
    }
}
