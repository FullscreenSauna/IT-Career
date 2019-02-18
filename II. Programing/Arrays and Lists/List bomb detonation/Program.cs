using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_bomb_detonation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> main = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToList();

            int[] parameters = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToArray();

            int bomb = parameters[0];
            int power = parameters[1];

            int lenght = main.Count;

            for (int i = 0; i < main.Count; i++)
            {
                if (main[i] == bomb)
                {
                    if (i + power > main.Count - 1)
                    {
                        main.RemoveRange(i - power, power + main.Count - i);
                    }
                    else if (i - power < 0)
                    {
                        main.RemoveRange(0, i + power + 1);
                    }
                    else
                    {
                        main.RemoveRange(i - power, (power * 2) + 1);
                    }                   
                    i = 0;
                }

            }


            Console.WriteLine(main.Sum());
        }
    }
}
