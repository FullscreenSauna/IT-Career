using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_merge
{
    class Program
    {
        static void Main(string[] args)
        {
            var lists = Console.ReadLine().Split('|').ToList();

            var mergedLists = new List<int>();

            for (int i = lists.Count - 1; i >= 0; i--)
            {
                List<int> currentNumber = lists[i].Split(' ').Where(x => x != "").Select(int.Parse).ToList();

                mergedLists.AddRange(currentNumber);
            }

            Console.WriteLine(string.Join(" ", mergedLists));
        }
    }
}
