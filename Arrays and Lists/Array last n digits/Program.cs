using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_last_n_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] sequence = new int[n];

            sequence[0] = 1;

            int nextInSeq = 0;

            for (int i = 1; i < n; i++)
            {
                int stepBack = i;

                if (i <= k)
                {
                    nextInSeq = sequence.Sum();
                }
                else
                {
                    nextInSeq = sequence[i - k];
                    for (int j = 1; j < k; j++)
                    {
                        stepBack--;
                        nextInSeq += sequence[stepBack];
                    }
                }

                sequence[i] = nextInSeq;
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
