﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stupid_Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    for (int z = 97; z < 97 + l; z++)
                    {
                        for (int k = 97; k < 97 + l; k++)
                        {
                            for (int m = 1; m <= n; m++)
                            {
                                if (m > i && m > j)
                                {
                                    Console.Write($" {i}{j}{(char)z}{(char)k}{m}");
                                }
                            }
                        }
                    }
                }
            }




        }
    }
}

