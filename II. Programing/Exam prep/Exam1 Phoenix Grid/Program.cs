using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam1_Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            while (message != "ReadMe")
            {
                var phrases = message.Split('.').ToArray();

                bool isValid = true;

                foreach (var phrase in phrases)
                {
                    if (phrase.Contains(' ') || phrase.Contains('_') || phrase.Length != 3)
                    {
                        isValid = false;
                        break;
                    }
                }

                if (isValid)
                {
                    string finalMessage = string.Join("", phrases);

                    bool isPalindrome = true;

                    for (int i = 0; i < finalMessage.Length; i++)
                    {
                        if (finalMessage[i] != finalMessage[finalMessage.Length - 1 - i])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }

                    if (isPalindrome)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }

                message = Console.ReadLine();
            }
        }
    }
}
