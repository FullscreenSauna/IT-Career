using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_of_character_codes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var string1 = input[0];
            var string2 = input[1];

            int length = Math.Min(string1.Length, string2.Length);
            int i = 0;

            int result = 0;

            for (; i < length; i++)
            {
                result += string1[i] * string2[i];
            }

            if (i < string1.Length)
            {
                for (; i < string1.Length; i++)
                {
                    result += string1[i];
                }
            }
            else if (i < string2.Length)
            {
                for (; i < string2.Length; i++)
                {
                    result += string2[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
