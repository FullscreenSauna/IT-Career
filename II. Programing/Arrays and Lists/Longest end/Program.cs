using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_end
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();
            var arr2 = Console.ReadLine().Split(' ').Where(x => x != "").ToArray();

            int smallestLenght = Math.Min(arr1.Length, arr2.Length);
            int count1 = 0;
            int count2 = 0;

            for (int i = 0; i < smallestLenght; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    count1++;
                }
            }

            int indexOfComparison1 = arr1.Length - 1;
            int indexOfComparison2 = arr2.Length - 1;

            for (int i = smallestLenght - 1; i >= 0; i--)
            {
                if (arr1[indexOfComparison1] == arr2[indexOfComparison2])
                {
                    count2++;
                }

                indexOfComparison1--;
                indexOfComparison2--;
            }

            Console.WriteLine(Math.Max(count1, count2));
        }
    }
}
