using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_person_and_his_money
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            person1.Name = "Pesho";
            person1.Age = 25;

            var account1 = new BankAccount();

            account1.Id = 1;
            account1.Ballance = 25;

            var account2 = new BankAccount();

            account2.Id = 2;
            account2.Ballance = 75;

            var person1Accounts = new List<BankAccount>
            {
                account1,
                account2
            };

            person1.Accounts = person1Accounts;

            person1.CalculateMoney();
        }
    }
}
