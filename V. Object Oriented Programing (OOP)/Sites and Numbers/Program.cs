using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sites_and_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split().ToArray();

            string[] websites = Console.ReadLine().Split().ToArray();

            Smartphone smartphone = new Smartphone(phoneNumbers, websites);

            Console.WriteLine(smartphone.Call());
            Console.WriteLine(smartphone.Browse());
        }
    }
}
