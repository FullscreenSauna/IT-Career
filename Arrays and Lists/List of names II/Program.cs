using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace List_of_names_II
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string[] fullNames = Regex.Split(input, ", ");

            var reversedNames = new List<string>();

            for (int i = 0; i < fullNames.Length; i++)
            {
                var a = fullNames[i];

                var b = a.Split(' ').ToList();

                reversedNames.Add($"{b[1]} {b[0]}");

                Console.WriteLine(reversedNames[i]);
            }
        }
    }
}
