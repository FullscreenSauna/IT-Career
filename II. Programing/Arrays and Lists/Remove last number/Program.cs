using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_last_number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Where(x => x != "").Select(int.Parse).ToList();

            int lastNumber = numbers[numbers.Count - 1];

            numbers.RemoveAll(x => x == lastNumber);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
