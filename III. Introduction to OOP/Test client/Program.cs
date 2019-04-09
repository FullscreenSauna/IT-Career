using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_client
{
    class Program
    {
        static void Main(string[] args)
        {
            var accounts = new Dictionary<int, BankAccount>();

            var commandArgs = Console.ReadLine().Split();
            var command = commandArgs[0];

            while (command != "End")
            {
                switch (command)
                {
                    case "Create":
                        Create(commandArgs, accounts);
                        break;

                    case "Deposit":
                        Deposit(commandArgs, accounts);
                        break;

                    case "Withdraw":
                        Withdraw(commandArgs, accounts);
                        break;

                    case "Print":
                        Print(commandArgs, accounts);
                        break;
                }

                commandArgs = Console.ReadLine().Split();
                command = commandArgs[0];
            }
        }

        private static void Print(string[] commandArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commandArgs[1]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                Console.WriteLine(accounts[id].ToString());
            }
        }

        private static void Withdraw(string[] commandArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commandArgs[1]);
            var ammount = int.Parse(commandArgs[2]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else if (ammount > accounts[id].ballance)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                accounts[id].ballance -= ammount;
            }
        }

        private static void Deposit(string[] commandArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commandArgs[1]);

            if (!accounts.ContainsKey(id))
            {
                Console.WriteLine("Account does not exist");
            }
            else
            {
                var ammount = int.Parse(commandArgs[2]);

                accounts[id].ballance += ammount;
            }
        }

        private static void Create(string[] commandArgs, Dictionary<int, BankAccount> accounts)
        {
            var id = int.Parse(commandArgs[1]);

            if (accounts.ContainsKey(id))
            {
                Console.WriteLine("Account already exists");
            }
            else
            {
                var acc = new BankAccount();
                acc.ID = id;
                accounts.Add(id, acc);
            }
        }
    }
}
