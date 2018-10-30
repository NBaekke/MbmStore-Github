using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    // derived class af product
    {
        // fields
        private string author;
        private string publisher;
        private short published;
        private string isbn;

        // properties
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public short Published
        {
            get { return published; }
            set { published = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        // constructors
        public Book() { }

        public Book(int productID, string author, string title, decimal price, string publisher, short published, string isbn, string imageUrl) : base(productID, title, price, imageUrl)
        {
            this.author = author;
            this.publisher = publisher;
            this.published = published; 
            this.isbn = isbn;
        }
    }
}
