using System;
using Transit_price.Controllers;

namespace Transit_price
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controller = new Controller();
            controller.GetPrice();
        }
    }
}
