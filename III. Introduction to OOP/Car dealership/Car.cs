using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Car_dealership
{
    class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car() { }

        public Car(string model, Engine engine) : this(model, engine, 0, "n/a") { }

        public Car(string model, Engine engine, string color) : this(model, engine, 0, color) { }

        public Car(string model, Engine engine, int weight) : this(model, engine, weight, "n/a") { }

        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Weight = weight;
            Color = color;
            Engine = engine;
        }

        public string Model { get => model; set => model = value; }
        public int Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }
        internal Engine Engine { get => engine; set => engine = value; }

        public override string ToString()
        {
            return $"{model}: \n {engine} \n Weight: {(weight == 0 ? "n/a":weight.ToString())} \n Color: {color}";
        }
    }
}
