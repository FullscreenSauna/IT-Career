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

            long result = 0;

            for (int i = 0; i < n; i++)
            {               
                id = long.Parse(Console.ReadLine());

                switch (type)
                {
                    case "sbyte":
                        if (id > biggest && id <= sbyte.MaxValue)
                        {
                            result = id;
                        }
                        break;

                    case "int":
                        if (id > biggest && id <= int.MaxValue)
                        {
                            result = id;
                        }
                        break;

                    case "long":
                        if (id > biggest && id <= long.MaxValue)
                        {
                            result = id;
                        }
                        break;
                }

                if (biggest < id)
                {
                    biggest = id;
                }
            }

            Console.WriteLine();
            Console.WriteLine(result);
        }
    }
}
