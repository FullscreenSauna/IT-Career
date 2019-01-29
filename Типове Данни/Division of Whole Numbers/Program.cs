using System;

namespace Division_of_Whole_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 0;
            int leftover = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                if (i % 2 == 0)
                {
                    a = int.Parse(Console.ReadLine());

                }
                else
                {
                    b = int.Parse(Console.ReadLine());
                    leftover += a % b;
                }
            }

            Console.WriteLine(leftover);
        }
    }
}
