using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_with_suffixes_and_prefixes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            double number = 0;
            double endResult = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentSet = input[i];

                number = FindNumber(currentSet);

                bool isPast = false;
                bool isLowercase = false;

                CalculateCurrentSetValue(ref number, currentSet, ref isPast, ref isLowercase);

                endResult += number;
            }

            Console.WriteLine($"{endResult:f2}");
        }

        private static void CalculateCurrentSetValue(ref double number, string currentSet, ref bool isPast, ref bool isLowercase)
        {
            for (int j = 0; j < currentSet.Length; j++)
            {
                char currentChar = currentSet[j];

                if (char.IsLower(currentChar))
                {
                    isLowercase = true;
                }
                else
                {
                    isLowercase = false;
                }

                if (char.IsDigit(currentChar))
                {
                    isPast = true;
                }
                else
                {
                    int positionInAlphabet = 0;

                    if (isLowercase)
                    {
                        positionInAlphabet = currentChar - 96;
                    }
                    else
                    {
                        positionInAlphabet = currentChar - 64;
                    }

                    if (isPast)
                    {
                        if (isLowercase)
                        {
                            number += positionInAlphabet;
                        }
                        else
                        {
                            number -= positionInAlphabet;
                        }
                    }
                    else
                    {
                        if (isLowercase)
                        {
                            number *= positionInAlphabet;
                        }
                        else
                        {
                            number /= positionInAlphabet;
                        }
                    }
                }

            }
        }

        private static double FindNumber(string currentSet)
        {
            double number;
            var numberBuilder = new StringBuilder();

            for (int j = 0; j < currentSet.Length; j++)
            {
                if (char.IsDigit(currentSet[j]))
                {
                    numberBuilder.Append(currentSet[j]);
                }
            }

            number = double.Parse(numberBuilder.ToString());
            return number;
        }
    }
}
