using System;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                double digit = double.Parse(input);

                Console.WriteLine("digit");

            }
            catch (FormatException)
            {

                bool isVowel = IsVowel(char.Parse(input));

                if (isVowel)
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }

        }

        public static bool IsVowel(char charValue)
        {
            char[] vowelList = { 'a', 'e', 'i', 'o', 'u', 'y' };

            char casedChar = char.ToLower(charValue);

            foreach (char vowel in vowelList)
            {
                if (vowel == casedChar)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
