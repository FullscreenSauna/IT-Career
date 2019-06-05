using System;

namespace Online_Store
{
    public class Product
    {
        private string name;
        private double price;
        private bool isOnPromotion;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Trim().Length < 3)
                {
                    throw new ArgumentException("Invalid product name!");
                }

                name = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0.00)
                {
                    throw new ArgumentException("Price should be positive!");
                }

                price = value;
            }
        }

        public bool IsOnPromotion
        {
            get { return isOnPromotion; }
        }

        public Product(string name, double price, bool isOnPromotion)
        {
            this.Name = name;
            this.isOnPromotion = isOnPromotion;

            if (isOnPromotion)
            {
                Price = price * 0.8;
            }
            else
            {
                Price = price;
            }
        }

        public Product(string name, double price) : this(name, price, false) { }

        public override string ToString()
        {
            string message = "NO";

            if (isOnPromotion)
            {
                message = "YES";
            }

            return $"Product -> {name} with price {price:f2}. On promotion {message}";
        }
    }
}