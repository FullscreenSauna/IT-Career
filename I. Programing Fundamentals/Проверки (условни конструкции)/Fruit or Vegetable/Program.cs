﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();

            string type = string.Empty;

            if (product == "banana" || product == "apple" || product == "kiwi" || product == "cherry" || 
                product == "lemon" || product == "grapes")
            {
                type = "fruit";
            }
            else if (product == "tomato" || product == "cucumber" || product == "pepper" || product == "carrot")
            {
                type = "vegetable";
            }
            else
            {
                type = "unknown";
            }

            Console.WriteLine(type);
        }
    }
}
