using System;

namespace Fitting_an_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            long number;

            Console.WriteLine();
            try
            {
                number = sbyte.Parse(input);

                Console.WriteLine($"{number} can fit in:");
                Console.WriteLine("* sbyte");
                if (number >= 0)
                {
                    Console.WriteLine("* byte");
                }
                Console.WriteLine("* short");
                if (number >= 0)
                {
                    Console.WriteLine("* ushort");
                }
                Console.WriteLine("* int");
                if (number >= 0)
                {
                    Console.WriteLine("* uint");
                }
                Console.WriteLine("* long");
            }
            catch (OverflowException)
            {
                try
                {
                    number = byte.Parse(input);

                    Console.WriteLine($"{number} can fit in:");
                    Console.WriteLine("* byte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* ushort");
                    Console.WriteLine("* int");
                    Console.WriteLine("* uint");
                    Console.WriteLine("* long");
                }
                catch (OverflowException)
                {
                    try
                    {
                        number = short.Parse(input);

                        Console.WriteLine($"{number} can fit in:");
                        Console.WriteLine("* short");
                        if (number >= 0)
                        {
                            Console.WriteLine("* ushort");
                        }
                        Console.WriteLine("* int");
                        if (number >= 0)
                        {
                            Console.WriteLine("* uint");
                        }
                        Console.WriteLine("* long");
                    }
                    catch (OverflowException)
                    {
                        try
                        {
                            number = ushort.Parse(input);

                            Console.WriteLine($"{number} can fit in:");
                            Console.WriteLine("* ushort");
                            Console.WriteLine("* int");
                            Console.WriteLine("* uint");
                            Console.WriteLine("* long");
                        }
                        catch (OverflowException)
                        {
                            try
                            {
                                number = int.Parse(input);

                                Console.WriteLine($"{number} can fit in:");
                                Console.WriteLine("* int");
                                if (number >= 0)
                                {
                                    Console.WriteLine("* uint");
                                }
                                Console.WriteLine("* long");
                            }
                            catch (OverflowException)
                            {
                                try
                                {
                                    number = uint.Parse(input);

                                    Console.WriteLine($"{number} can fit in:");
                                    Console.WriteLine("* uint");
                                    Console.WriteLine("* long");
                                }
                                catch (OverflowException)
                                {
                                    try
                                    {
                                        number = long.Parse(input);

                                        Console.WriteLine($"{number} can fit in:");
                                        Console.WriteLine("* long");
                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine($"{input} can't fit any type");
                                    }
                                }
                            }
                        }
                    }
                }
            }



        }
    }
}
