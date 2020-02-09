using CryptoMiningSystem.Entities.Components.Processors;
using CryptoMiningSystem.Entities.Components.VideoCards;
using CryptoMiningSystem.Entities.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoMiningSystem.Entities
{
    public class Computer
    {
        private Processor processor;
        private VideoCard videoCard;
        private int ram;

        public Computer(Processor processor, VideoCard videoCard, int ram)
        {
            Ram = ram;
            VideoCard = videoCard;
            Processor = processor;
        }

        public int Ram
        {
            get { return ram; }
            private set
            {
                if (value < 1 || value > 32)
                {
                    throw new ArgumentException("PC Ram cannot be less or equal to 0 and more than 32!");
                }
                ram = value;
            }
        }


        public VideoCard VideoCard
        {
            get { return videoCard; }
            set { videoCard = value; }
        }

        public Processor Processor
        {
            get { return processor; }
            set { processor = value; }
        }

        public decimal MinedAmountPerHour => this.VideoCard.MinedMoneyPerHour * this.Processor.MineMultiplier;
    }
}
