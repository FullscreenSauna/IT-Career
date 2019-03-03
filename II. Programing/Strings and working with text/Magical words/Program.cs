using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magical_words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var firstWord = input[0];
            var secondWord = input[1];

            bool isEquivalent = true;

            if (firstWord.Length == secondWord.Length)
            {
                isEquivalent = SameWordLength(firstWord, secondWord, isEquivalent);
            }
            else
            {
                isEquivalent = DifferentWordLenght(firstWord, secondWord, isEquivalent);
            }

            Console.WriteLine(isEquivalent.ToString().ToLower());
        }

        private static bool SameWordLength(string firstWord, string secondWord, bool isEquivalent)
        {
            for (int i = 0; i < firstWord.Length; i++)
            {
                char currentLetter = firstWord[i];
                char currentEquivalent = secondWord[i];

                for (int j = 0; j < firstWord.Length; j++)
                {
                    char letterCheck = firstWord[j];
                    char equivalentCheck = secondWord[j];

                    if (currentLetter == letterCheck && currentEquivalent != equivalentCheck)
                    {
                        isEquivalent = false;
                        break;
                    }
                }

                if (!isEquivalent)
                {
                    break;
                }
            }

            return isEquivalent;
        }

        private static bool DifferentWordLenght(string firstWord, string secondWord, bool isEquivalent)
        {
            var newFirstWord = new List<char>();
            newFirstWord.AddRange(firstWord);
            int firstWordCounter = 0;

            while (newFirstWord.Count > 0)
            {
                char letter = newFirstWord[0];
                newFirstWord.RemoveAll(x => x == letter);
                firstWordCounter++;
            }

            var newSecondWord = new List<char>();
            newSecondWord.AddRange(secondWord);
            int secondWordCounter = 0;

            while (newSecondWord.Count > 0)
            {
                char letter = newSecondWord[0];
                newSecondWord.RemoveAll(x => x == letter);
                secondWordCounter++;
            }

            if (firstWordCounter != secondWordCounter)
            {
                isEquivalent = false;
            }

            return isEquivalent;
        }


    }
}
