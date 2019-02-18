using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int giftMoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    giftMoney += 10;
                    money += giftMoney - 1;
                }
                else
                {
                    toys++;
                }
            }

            money += toys * toyPrice;

            if (money >= washingMachine)
            {
                double moneyLeft = money -washingMachine;

                Console.WriteLine($"Yes! {moneyLeft:f2}");
            }
            else
            {
                double moneyNeeded = washingMachine - money;

                Console.WriteLine($"No! {moneyNeeded:f2}");
            }
        }
    }
}
