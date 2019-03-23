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
                var phrases = new List<string>();

                bool isValid = true;

                string phrase = "";

                for (int i = 0; i < message.Length; i++)
                {                  
                    if (phrase.Length != 3)
                    {
                        phrase += message[i];
                    }
                    else if (message[i] == '.')
                    {
                        phrases.Add(phrase);
                        phrase = "";
                    }
                    else if (message[i] != '.')
                    {
                        isValid = false;
                        break;
                    }
                }

                phrases.Add(phrase);

                foreach (var item in phrases)
                {
                    if (item.Contains(' ') || item.Contains('_'))
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
