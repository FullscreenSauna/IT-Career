using System;

namespace Combining_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            char divider = char.Parse(Console.ReadLine());
            string numberCheck = Console.ReadLine().ToLower();
            int n = int.Parse(Console.ReadLine());

            string result = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string word = Console.ReadLine();

                switch (numberCheck)
                {
                    case "even":
                        if (i % 2 == 0)
                        {
                            result += word + divider;
                        }
                        break;

                    case "odd":
                        if (i % 2 != 0)
                        {
                            result += word + divider;
                        }
                        break;
                }
            }

            result = result.Remove(result.Length - 1);
            Console.WriteLine(result);
        }
    }
}
