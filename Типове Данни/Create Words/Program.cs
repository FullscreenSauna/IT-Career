using System;

namespace Create_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string word = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char letter = char.Parse(Console.ReadLine()); ;

                word += letter;
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
