using CryptoMiningSystem.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities
{
    public class User
    {
        private string name;
        private decimal money;
        private Computer computer;

        public User(string name, decimal money)
        {
            Money = money;
            Name = name;
        }

        public decimal Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("User's money cannot be less than 0!");
                }

                money = value;
            }
        }

        public string Name
        {
            get { return name; }
            private set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Username must not be null or empty!");
                }

                name = value;
            }
        }

        public Computer Computer { get => computer; set => computer = value; }

        public int Stars => (int)(this.Money / 100);

    }
}
