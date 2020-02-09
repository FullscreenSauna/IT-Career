using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    using CryptoMiningSystem.Entities.Components;
    using Contracts;
    using System;

    public abstract class VideoCard : Component
    {
        private decimal ram;

        protected VideoCard(string model, decimal generation, decimal ram, decimal price)
             : base(model, generation, price)
        {
            Ram = ram;
        }

        public decimal Ram
        {
            get { return ram; }
            private set
            {
                if (value <= 0 || value > 32)
                {
                    throw new ArgumentException($"{this.GetType().Name} ram cannot be less or equal to 0 and more than 32!");
                }

                ram = value;
            }
        }

        public virtual decimal MinedMoneyPerHour => Ram * Generation / 10;
    }
}
