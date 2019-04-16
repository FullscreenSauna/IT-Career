using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Car_dealership
{
    class Engine
    {
        private string model;
        private int power;
        private int displacement;
        private string efficiency;

        public Engine() { }

        public Engine(string model, int power) : this(model, power, 0, "n/a") { }

        public Engine(string model, int power, int displacement) : this(model, power, displacement, "n/a") { }

        public Engine(string model, int power, string eficiency) : this(model, power, 0, eficiency) { }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
        

        public string Model { get => model; set => model = value; }
        public int Power { get => power; set => power = value; }
        public int Displacement { get => displacement; set => displacement = value; }
        public string Efficiency { get => efficiency; set => efficiency = value; }

        public override string ToString()
        {
            return $"{model}: \n Power: {power} \n Displacement: {(displacement == 0 ? "n/a":displacement.ToString())} \n Efficiency: {efficiency}";
        }
    }
}
