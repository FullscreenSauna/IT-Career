using System;

namespace Decripting_a_message
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var message = string.Empty;

            for (int i = 0; i < n; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                symbol += (char)key;

                message += symbol;
            }

            Console.WriteLine(message);
        }
    }
}
