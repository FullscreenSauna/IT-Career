using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Online_Store
{
    public class Order
    {
        private int orderNumber;
        private List<Product> products;

        private static int ordersCount;

        public int OrderNumber
        {
            get { return orderNumber; }
            set { orderNumber = value; }
        }

        public static int OrdersCount
        {
            get { return ordersCount; }
        }

        public Order(int orderNumber, List<Product> products)
        {
            this.orderNumber = orderNumber;
            this.products = products;
            ordersCount++;
        }
  
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public double GetOrderTotalPrice()
        {
           return products.Sum(p => p.Price);
        }

        public double GetDiscountedProductsTotalPrice()
        {
            return products.Where(p => p.IsOnPromotion).Sum(p => p.Price);
        }

        public int GetDiscountedProductsCount()
        {
            return products.Count(p => p.IsOnPromotion);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Order #{orderNumber} has the following products:");

            products.ForEach(p => sb.Append($"\n###{p.ToString()}"));

            return sb.ToString();
        }
    }
}