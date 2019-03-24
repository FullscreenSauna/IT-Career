using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Word_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int maxPoints = 0;
            string finalWord = "";

            while (word != "END OF GAME")
            {
                int totalPoints = 0;

                if (char.IsUpper(word[0]))
                {
                    totalPoints += 15;
                }

                if (word[word.Length - 1] == 't')
                {
                    totalPoints += 20;
                }

                if (word.Length >= 10)
                {
                    totalPoints += 30;
                }

                foreach (var letter in word)
                {
                    totalPoints += letter;
                }

                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    finalWord = word;
                }

                word = Console.ReadLine();
            }

            Console.WriteLine($"Winner is word: {finalWord}");
            Console.WriteLine($"Points: {maxPoints}");
        }
    }
}
