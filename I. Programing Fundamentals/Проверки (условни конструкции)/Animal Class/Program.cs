using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine().ToLower();

            string type = string.Empty;

            if (animal == "dog")
            {
                type = "mammal";
            }
            else if (animal == "crocodile" || animal == "tortoise" || animal == "snake")
            {
                type = "reptile";
            }
            else
            {
                type = "unknown";
            }

            Console.WriteLine(type);
        }
    }
}
