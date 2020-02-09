using CryptoMiningSystem.Entities.Components.Contracts;
using System;
using System.Collections.Generic;
using System.Text;


namespace CryptoMiningSystem.Entities
{
    public abstract class Component
    {
        private const int startingGeneration = 1;

        private string model;
        private decimal price;
        private decimal generation = startingGeneration;

        protected Component(string model, decimal generation, decimal price)
        {
            Model = model;
            Price = price;
            Generation = generation;

        }

        public string Model
        {
            get => model;
            private set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentException("Model cannot be null or empty!");
                }

                model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (value <= 0 || value > 10000)
                {
                    throw new ArgumentException("Price cannot be less or equal to 0 and more than 10000!");
                }

                price = value;
            }
        }

        public virtual decimal Generation
        {
            get { return generation; }
           protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Generation cannot be 0 or negative!");
                }

                generation = value;
            }
        }

        public decimal LifeWorkingHours { get; set; }


    }
}
