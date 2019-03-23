using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            short numberOfSites = short.Parse(Console.ReadLine());
            short securityKey = short.Parse(Console.ReadLine());

            var webSites = new List<string>();
            decimal totalLoss = 0M;

            for (int i = 0; i < numberOfSites; i++)
            {
                var info = Console.ReadLine().Split(' ').ToArray();

                webSites.Add(info[0]);
                totalLoss += uint.Parse(info[1]) * decimal.Parse(info[2]);
            }

            foreach (var site in webSites)
            {
                Console.WriteLine(site);
            }

            Console.WriteLine($"Total Loss: {totalLoss:f20}");
            Console.WriteLine($"Security Token: {Math.Pow(securityKey,numberOfSites)}");
        }
    }
}
