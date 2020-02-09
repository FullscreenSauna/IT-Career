using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.Processors
{
    public abstract class Processor : Component
    {
        protected Processor(string model, decimal generation, decimal price)
            : base(model, generation, price)
        {
            LifeWorkingHours = Generation * 100;
        }

        public override decimal Generation
        {
            get { return base.Generation; }
          protected  set
            {
                if (value > 9)
                {
                    throw new ArgumentException($"{this.GetType().Name} generation cannot be more than 9!");
                }

                base.Generation = value;
            }
        }

        public abstract int MineMultiplier { get; }
    }
}
