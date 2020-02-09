using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities.Components.Processors
{

    public class HighPerformanceProcessor : Processor
    {
        private const int miningMultiplier = 8;

        public HighPerformanceProcessor(string model, decimal generation, decimal price)
            : base(model, generation, price)
        {
        }

        public override int MineMultiplier => miningMultiplier;
    }
}
