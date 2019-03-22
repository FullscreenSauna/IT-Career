using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_mail_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string oldInput = null;

            var emails = new Dictionary<string, string>();

            int i = 0;

            while (input != "stop")
            {
                if (i % 2 == 0)
                {
                    emails.Add(input, null);
                }
                else
                {
                    emails[oldInput] = input;
                }

                oldInput = input;
                i++;
                input = Console.ReadLine();
            }

            foreach (var pair in emails)
            {
                if (pair.Value[pair.Value.Length - 1] != 'k' && pair.Value[pair.Value.Length - 1] != 's')
                {
                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                }
            }
        }
    }
}
