using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fitness_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            short treadmillPrice = 5899;
            short crossTrainerPrice = 1699;
            short ExerciseBikePrice = 1789;
            short dumbbelsPrice = 579;

            short equipmentCount = short.Parse(Console.ReadLine());

            decimal totalPrice = 0M;

            for (int i = 0; i < equipmentCount; i++)
            {
                string equipmentType = Console.ReadLine();

                switch (equipmentType)
                {
                    case "treadmill":
                        totalPrice += treadmillPrice;
                        break;

                    case "cross trainer":
                        totalPrice += crossTrainerPrice;
                        break;

                    case "exercise bike":
                        totalPrice += ExerciseBikePrice;
                        break;

                    case "dumbbells":
                        totalPrice += dumbbelsPrice;
                        break;
                }
            }

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
