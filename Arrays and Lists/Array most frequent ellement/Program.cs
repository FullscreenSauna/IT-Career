using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_most_frequent_ellement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split(' ')
                .Where(x => x != "")
                .Select(int.Parse)
                .ToArray();

            int maxCounter = 0;
            int commonNumber = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentCounter = 0;

                for (int j = i; j < input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        currentCounter++;
                    }
                }

                if(currentCounter > maxCounter)
                {
                    commonNumber = input[i];
                    maxCounter = currentCounter;
                }
            }

            Console.WriteLine(commonNumber);
        }
    }
}
