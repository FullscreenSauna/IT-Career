using System;

namespace Check_FP_or_Int
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                long input = long.Parse(Console.ReadLine());
                Console.WriteLine("integer");
            }
            catch (FormatException)
            {

                Console.WriteLine("floating-point");
            }
            
        }
    }
}
