using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            long mainMaterial = 0;
            int secondaryMaterial = 0;

            if (input1 < 128)
            {
                secondaryMaterial = input1;
                mainMaterial = input2;
            }
            else
            {
                secondaryMaterial = input2;
                mainMaterial = input1;
            }

            Console.WriteLine(mainMaterial * 10 + secondaryMaterial * 4);
        }
    }
}
