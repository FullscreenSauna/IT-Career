using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Password
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();

            if (password == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wellcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
