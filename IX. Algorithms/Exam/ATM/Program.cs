using System;
using System.Collections.Generic;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] banknotes = new int[] { 100, 50, 20, 10, 5, 2, 1};
            int[] noteCounter = new int[banknotes.Length];

            int wantedAmmount = int.Parse(Console.ReadLine());

            // count notes using Greedy approach 
            for (int i = 0; i < banknotes.Length; i++)
            {
                if (wantedAmmount >= banknotes[i])
                {
                    noteCounter[i] = wantedAmmount / banknotes[i];
                    wantedAmmount = wantedAmmount - noteCounter[i] * banknotes[i];
                }
            }

            int noteCount = 0;
            for (int i = 0; i < noteCounter.Length; i++)
            {
                noteCount += noteCounter[i];
            }

            Console.WriteLine(noteCount);
        }
    }
}

