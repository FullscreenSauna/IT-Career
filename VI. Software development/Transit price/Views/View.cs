using System;
using System.Collections.Generic;
using System.Text;
using Transit_price.Models;

namespace Transit_price.Views
{
    public class View
    {
        public View()
        {
            GetInput();
        }

        public Model Model { get; set; }

        private void GetInput()
        {
            Console.WriteLine("Kilometers:");
            int kilometers = int.Parse(Console.ReadLine());
            Console.WriteLine("Time:");
            string time = Console.ReadLine();

            this.Model = new Model(kilometers, time);
        }

        public decimal GetPrice()
        {
            return Model.GetPrice();
        }
    }
}
