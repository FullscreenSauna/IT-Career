using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> models = new List<string>();
            List<string> robotIds = new List<string>();

            List<string> names = new List<string>();
            List<string> citizenIds = new List<string>();
            List<int> ages = new List<int>();

            string[] comand = Console.ReadLine().Split();

            while (comand[0] != "End")
            {
                if (comand.Length == 2)
                {
                    models.Add(comand[0]);
                    robotIds.Add(comand[1]);
                }
                else
                {
                    names.Add(comand[0]);
                    ages.Add(int.Parse(comand[1]));
                    citizenIds.Add(comand[2]);
                }

                comand = Console.ReadLine().Split();
            }

            string fakeIdSnippet = Console.ReadLine();

            Citizens citizens = new Citizens(citizenIds, names, ages);

            Robots robots = new Robots(robotIds, models);

            Console.WriteLine(string.Join(" ", citizens.IdentifyCriminals(fakeIdSnippet)));
            Console.WriteLine(string.Join(" ", robots.IdentifyCriminals(fakeIdSnippet)));
        }
    }
}
