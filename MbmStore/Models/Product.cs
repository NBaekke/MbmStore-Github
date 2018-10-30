using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    // base class
    {
        // fields
        private int productID;
        private string title;
        private decimal price;
        private string imageUrl;

        // properties
        public int ProductID
        {
            get { return productID; }
            set { productID = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }
        // public giver alle adgange til disse properties

        // constructors
        public Product() {}

        public Product(string title, decimal price)
        {
            this.title = title;
            this.price = price;
        }

        public Product(int productID, string title, decimal price, string imageUrl)
        {
            this.productID = productID;
            this.title = title;
            this.price = price;
            this.imageUrl = imageUrl;
        }
    }
}
