using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public class ProductInfo
    {
        private double price;
        private int quantity;

        public double Price { get { return price; } set { price = value; } }
        public int Quantity { get { return quantity; } set { quantity = value; } }

        public ProductInfo(double price, int quantity) 
        { 
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}
