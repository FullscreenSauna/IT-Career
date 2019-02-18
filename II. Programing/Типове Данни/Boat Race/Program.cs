using System;

namespace Boat_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            char boat1 = char.Parse(Console.ReadLine());
            char boat2 = char.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            int boatOnePlace = 0;
            int boatTwoplace = 0;

            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();
                int wordLenght = word.Length;

                if (word == "UPGRADE")
                {
                    boat1 += (char)3;
                    boat2 += (char)3;
                }
                else
                {
                    if(i % 2 == 0)
                    {
                        boatTwoplace += wordLenght;
                    }
                    else
                    {
                        boatOnePlace += wordLenght;
                    }
                }

                if (boatOnePlace >= 50 || boatTwoplace >= 50)
                {
                    break;
                }
            }

            Console.WriteLine();

            if (boatOnePlace > boatTwoplace)
            {
                Console.WriteLine(boat1);
            }
            else
            {
                Console.WriteLine(boat2);
            }
        }
    }
}
