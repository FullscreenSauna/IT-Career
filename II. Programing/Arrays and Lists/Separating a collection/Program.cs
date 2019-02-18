using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Separating_a_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']')
                .Where(x => x != "")
                .ToArray();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();


            foreach (var currentElement in input)
            {
                bool isNotMixed = true;

                for (int i = 0; i < currentElement.Length; i++)
                {
                    if (!char.IsLetter(currentElement, i))
                    {
                        mixedCase.Add(currentElement);
                        isNotMixed = false;
                        break;
                    }
                }

                if (currentElement == currentElement.ToLower() && isNotMixed)
                {
                    lowerCase.Add(currentElement);
                }
                else if (currentElement == currentElement.ToUpper() && isNotMixed)
                {
                    upperCase.Add(currentElement);
                }
                else if (isNotMixed)
                {
                    mixedCase.Add(currentElement);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");          
        }
    }
}
