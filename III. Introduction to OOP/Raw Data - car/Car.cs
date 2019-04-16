using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Raw_Data___car
{
    class Car
    {
        private string model;
        private Engine engine;
        private Load load;
        private Tyre firstTire;
        private Tyre secondTire;
        private Tyre thirdTire;
        private Tyre fourthTire;

        public Car() { }

        public Car(string model, Engine engine, Load load, Tyre firstTire, Tyre secondTire, Tyre thirdTire, Tyre fourthTire)
        {
            Model = model;
            Engine = engine;
            Load = load;
            FirstTire = firstTire;
            SecondTire = secondTire;
            ThirdTire = thirdTire;
            FourthTire = fourthTire;
        }

        public string Model { get => model; set => model = value; }
        internal Engine Engine { get => engine; set => engine = value; }
        internal Load Load { get => load; set => load = value; }
        internal Tyre FirstTire { get => firstTire; set => firstTire = value; }
        internal Tyre SecondTire { get => secondTire; set => secondTire = value; }
        internal Tyre ThirdTire { get => thirdTire; set => thirdTire = value; }
        internal Tyre FourthTire { get => fourthTire; set => fourthTire = value; }
    }
}
