using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raw_Data___car
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var cars = new Dictionary<string, Car>();
            FillDictionary(n, cars);

            PrintResult(cars);
        }

        private static void PrintResult(Dictionary<string, Car> cars)
        {
            string command = Console.ReadLine();

            foreach (var car in cars)
            {
                switch (command)
                {
                    case "fragile":
                        bool isFragile = car.Value.Load.Type == "fragile";
                        bool checkFirstTyre = car.Value.FirstTire.Presure < 1;
                        bool checkSecondTire = car.Value.SecondTire.Presure < 1;
                        bool checkThirdTire = car.Value.ThirdTire.Presure < 1;
                        bool checkFourthTire = car.Value.FourthTire.Presure < 1;

                        if (isFragile && (checkFirstTyre || checkSecondTire || checkThirdTire || checkFourthTire))
                        {
                            Console.WriteLine(car.Key);
                        }
                        break;

                    case "flamable":
                        bool isFlamable = car.Value.Load.Type == "flamable";
                        bool checkEngine = car.Value.Engine.Power > 250;

                        if (isFlamable && checkEngine)
                        {
                            Console.WriteLine(car.Key);
                        }
                        break;
                }
            }
        }

        public static void FillDictionary(int n, Dictionary<string, Car> cars)
        {
            while (n-- > 0)
            {
                var info = Console.ReadLine().Split().ToArray();

                int speed = int.Parse(info[1]);
                int power = int.Parse(info[2]);

                Engine engine = new Engine(speed, power);

                int weight = int.Parse(info[3]);
                string type = info[4];

                Load load = new Load(weight, type);

                double pressure1 = double.Parse(info[5]);
                int age1 = int.Parse(info[6]);

                Tyre tyre1 = new Tyre(pressure1, age1);

                double pressure2 = double.Parse(info[7]);
                int age2 = int.Parse(info[8]);

                Tyre tyre2 = new Tyre(pressure2, age2);

                double pressure3 = double.Parse(info[9]);
                int age3 = int.Parse(info[10]);

                Tyre tyre3 = new Tyre(pressure3, age3);

                double pressure4 = double.Parse(info[11]);
                int age4 = int.Parse(info[12]);

                Tyre tyre4 = new Tyre(pressure4, age4);

                string model = info[0];

                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, new Car());
                }

                cars[model] = new Car(model, engine, load, tyre1, tyre2, tyre3, tyre4);
            }
        }
    }
}
