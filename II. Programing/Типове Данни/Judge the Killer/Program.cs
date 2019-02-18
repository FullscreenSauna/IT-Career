using System;

namespace Catch_the_Killer
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            long id = long.MinValue;
            long biggest = long.MinValue;

            long prisoner = 0;

            for (int i = 0; i < n; i++)
            {
                id = long.Parse(Console.ReadLine());

                switch (type)
                {
                    case "sbyte":
                        if (id > biggest && id <= sbyte.MaxValue)
                        {
                            prisoner = id;
                        }
                        break;

                    case "int":
                        if (id > biggest && id <= int.MaxValue)
                        {
                            prisoner = id;
                        }
                        break;

                    case "long":
                        if (id > biggest && id <= long.MaxValue)
                        {
                            prisoner = id;
                        }
                        break;
                }

                if (biggest < id)
                {
                    biggest = id;
                }
            }

            decimal sentence = 0;
            if (prisoner < 0)
            {
                sentence = Math.Ceiling((decimal)prisoner/ sbyte.MinValue);
            }
            else
            {
                sentence = Math.Ceiling((decimal)prisoner / sbyte.MaxValue);
            }

            Console.WriteLine();
            if (sentence > 1)
            {
                Console.WriteLine($"Prisoner with id {prisoner} is sentenced to {sentence} years");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {prisoner} is sentenced to {sentence} year");
            }
        }
    }
}
