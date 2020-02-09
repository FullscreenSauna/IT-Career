using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.VideoCards
{
    public class GameVideoCard : VideoCard
    {
        public GameVideoCard(string model, decimal generation, decimal ram, decimal price) 
            : base(model, generation, ram, price)
        {
            LifeWorkingHours = Ram * Generation * 10 * 2;
        }

        public override decimal Generation
        {
            get => base.Generation;
           protected set
            {
                if (value > 9)
                {
                    throw new ArgumentException("Game video card generation cannot be more than 9!");
                }

                base.Generation = value;
            }
        }

        public override decimal MinedMoneyPerHour => base.MinedMoneyPerHour * 2;
    }
}
