using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    public class MineVideoCard : VideoCard
    {
        public MineVideoCard(string model, decimal generation, decimal ram, decimal price) 
            : base(model, generation, ram, price)
        {
            LifeWorkingHours = Ram * Generation * 10;
        }

        public override decimal Generation
        {
            get => base.Generation;
          protected  set
            {
                if (value > 6)
                {
                    throw new ArgumentException("Mine video card generation cannot be more than 6!");
                }

                base.Generation = value;
            }
        }

        public override decimal MinedMoneyPerHour => base.MinedMoneyPerHour * 8;

    }
}
