using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Raw_Data___car
{
    class Tyre
    {
        private double pressure;
        private int age;

        public Tyre() { }


        public Tyre(double presure, int age)
        {
            Presure = presure;
            Age = age;
        }

        public double Presure { get => pressure; set => pressure = value; }
        public int Age { get => age; set => age = value; }
    }
}
