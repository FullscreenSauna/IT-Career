using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace A_person_and_his_money
{
    class Person
    {
        private string name;
        private int age;
        private List<BankAccount> accounts;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public List<BankAccount> Accounts
        {
            get { return accounts; }
            set { accounts = value; }
        }

        public void CalculateMoney()
        {
            if (accounts != null)
            {
                double ammount = 0;

                foreach (var account in accounts)
                {
                    ammount += account.Ballance;
                }

                Console.WriteLine(ammount);
            }
        }
    }
}
