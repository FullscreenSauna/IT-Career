using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int counter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == input[input.Length - 1 - i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            if (counter == input.Length)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
