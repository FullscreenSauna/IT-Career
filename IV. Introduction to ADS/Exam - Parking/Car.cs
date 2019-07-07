using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam___Parking
{
    class Car
    {
        public string CarNumber { get; set; }
        public Car Next { get; set; }

        public Car(string carNumber)
        {
            CarNumber = carNumber;
        }

        public override string ToString()
        {
            return $"Car: {CarNumber}";
        }
    }
}
