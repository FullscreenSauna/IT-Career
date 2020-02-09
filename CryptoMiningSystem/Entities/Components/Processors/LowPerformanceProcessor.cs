using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.Processors
{
    public class LowPerformanceProcessor : Processor
    {
        private const int miningMultiplier = 2;

        public LowPerformanceProcessor(string model, decimal price, decimal generation)
             : base(model, price, generation)
        {
        }

        public override int MineMultiplier => miningMultiplier;
    }
}
