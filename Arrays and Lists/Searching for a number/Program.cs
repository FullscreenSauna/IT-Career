using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching_for_a_number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToList();

            var parameters = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToArray();

            int ammountToTake = parameters[0];
            numbers.RemoveRange(ammountToTake, numbers.Count - ammountToTake);

            int ammountToRemove = parameters[1];
            numbers.RemoveRange(0, ammountToRemove);

            int number = parameters[2];
            if (numbers.Contains(number))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
