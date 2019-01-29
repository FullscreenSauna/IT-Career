using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double yuanInUSD = yuans * 0.15;

            double usdInBGN = yuanInUSD * 1.76;
            double bitcoinInBGN = bitcoins * 1168;

            double totalInBGN = bitcoinInBGN + usdInBGN;
            double totalInEUR = totalInBGN / 1.95;
            double totalTax = (totalInEUR) * tax / 100;

            double total = totalInEUR - totalTax;

            Console.WriteLine(total);
        }
    }
}
