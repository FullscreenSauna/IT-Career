using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomList
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomList random = new RandomList();

            random.Add("Gosho");
            random.Add("Pesho");
            random.Add("Sasho");
            random.Add("Tosho");

            random.RandomString();

            for (int i = 0; i < random.Count; i++)
            {
                Console.WriteLine(random[i]);
            }
        }
    }
}
