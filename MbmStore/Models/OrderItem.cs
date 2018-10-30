using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class OrderItem
    {
        // fields
        private int orderItemId;
        private int productId;
        private Product product;
        private int quantity;
        private decimal totalPrice;

        // properties
        public int OrderItemId
        {
            get { return orderItemId; }
            set { orderItemId = value; }
        }

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public Product Product
        {
            get { return product; }
            set { product = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPrice
        {
            get { return totalPrice; }
        }

        // constructors
        public OrderItem(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
    }
}
