using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Test_client
{
    class BankAccount
    {
        private int id;
        public double ballance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return $"Account {id}, ballance {ballance}";
        }
    }
}
