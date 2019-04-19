using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_dealership
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfEngines = int.Parse(Console.ReadLine());

            var engines = new Dictionary<string, Engine>();
            CreateEngines(numberOfEngines, engines);

            int numberOfCars = int.Parse(Console.ReadLine());

            var cars = new Dictionary<string, Car>();

            while (numberOfCars-- > 0)
            {
                var characteristics = Console.ReadLine().Split().Where(e => e != "").ToArray();

                string model = characteristics[0];
                string engineModel = characteristics[1];

                switch (characteristics.Length)
                {
                    case 2:
                        cars.Add(model, new Car(model, engines[engineModel]));
                        break;

                    case 3:
                        if (characteristics[2].All(char.IsNumber))
                        {
                            cars.Add(model, new Car(model, engines[engineModel], int.Parse(characteristics[2])));
                        }
                        else
                        {
                            cars.Add(model, new Car(model, engines[engineModel], characteristics[2]));
                        }
                        break;

                    case 4:
                        cars.Add(model, new Car(model, engines[engineModel], int.Parse(characteristics[2]), characteristics[3]));
                        break;
                }
            }

            cars.ToList().ForEach(c => Console.WriteLine(c.Value)); 
        }

        public static void CreateEngines(int numberOfEngines, Dictionary<string, Engine> engines)
        {
            while (numberOfEngines-- > 0)
            {
                var characteristics = Console.ReadLine().Split().ToArray();

                string model = characteristics[0];
                int power = int.Parse(characteristics[1]);

                switch (characteristics.Length)
                {
                    case 2:
                        if (!engines.ContainsKey(model))
                        {
                            engines.Add(model, new Engine(model, power));
                        }
                        break;

                    case 3:
                        if (characteristics[2].All(char.IsNumber))
                        {
                            engines.Add(model, new Engine(model, power, int.Parse(characteristics[2])));
                        }
                        else
                        {
                            engines.Add(model, new Engine(model, power, characteristics[2]));
                        }
                        break;

                    case 4:
                        engines.Add(model, new Engine(model, power, int.Parse(characteristics[2]), characteristics[3]));
                        break;
                }
            }
        }
    }
}
