﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int finish = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            for (int i = start; i > finish; i--)
            {
                if (i % 3 == 0 && i % 2 == 0)
                {
                    if (i == stop)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }
            }
        }
    }
}
