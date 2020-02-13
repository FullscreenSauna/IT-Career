using System;
using System.Collections.Generic;
using System.Text;

namespace Transit_price.Models
{
    public class Model
    {
        public Model(int kilometers, string time)
        {
            this.Kilometers = kilometers;
            this.Time = time;
        }

        public int Kilometers { get; set; }
        public string Time { get; set; }

        public decimal GetPrice()
        {
            decimal price = 0m;

            if (Kilometers >= 100) // => Train is best
            {
                price = Kilometers * 0.06m;
            }
            else if (Kilometers >= 20) // => Bus is best
            {
                price = Kilometers * 0.09m;
            }
            else // => Can only use Taxi
            {
                price = 0.7m;

                if (Time.ToLower() == "day") // Apply daytime pricing
                {
                    price += Kilometers * 0.79m;
                }
                else // Apply nighttime pricing
                {
                    price += Kilometers * 0.9m;
                }
            }

            return price;
        }
    }
}
