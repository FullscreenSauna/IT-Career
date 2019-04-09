using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bank_account
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public void Deposit(int ammount)
        {
            balance += ammount;
        }

        public void Withdraw(int ammount)
        {
            balance -= ammount;
        }

        public override string ToString()
        {
            return $"Account {id}, ballance {balance}";
        }
    }
}
