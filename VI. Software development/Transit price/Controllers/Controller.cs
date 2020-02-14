using System;
using System.Collections.Generic;
using System.Text;
using Transit_price.Views;
using Transit_price.Models;

namespace Transit_price.Controllers
{
    public class Controller
    {
        public View View { get; set; }
        public Model Model { get; set; }

        public Controller()
        {
            this.View = new View();
            this.Model = View.Model;
        }

        public void GetPrice()
        {
            View.GetPrice();
        }
    }
}
