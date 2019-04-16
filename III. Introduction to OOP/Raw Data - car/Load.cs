using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Raw_Data___car
{
    class Load
    {
        private int weight;
        private string type;

        public Load(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }

        public int Weight { get => weight; set => weight = value; }
        public string Type { get => type; set => type = value; }
    }
}
