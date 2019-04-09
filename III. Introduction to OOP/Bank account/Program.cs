using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_account
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.ID = 1;
            account.Deposit(15);
            account.Withdraw(5);

            Console.WriteLine(account.ToString());
        }
    }
}
