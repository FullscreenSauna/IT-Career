using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_letter_indexes
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                                'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            string word = Console.ReadLine();
            char[] letters = word.ToArray();

            foreach (char letter in letters)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (letter == alphabet[j])
                    {
                        Console.WriteLine($"{letter} -> {j}");
                        break;
                    }
                }
            }
        }
    }
}
