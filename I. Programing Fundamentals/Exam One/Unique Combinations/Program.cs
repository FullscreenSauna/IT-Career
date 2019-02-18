using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unique_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstLetter = int.Parse(Console.ReadLine());
            int secondLetter = int.Parse(Console.ReadLine());

            for (int i = firstLetter; i <= 122; i++)
            {
                for (int j = secondLetter; j <= 122; j++)
                {
                    for (int k = 1; k < 9; k++)
                    {
                        for (int l = 1; l < 9; l++)
                        {
                            if (i < j && k + l == 9)
                            {
                                Console.Write($"{(char)i}{(char)j}{k}{l} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
