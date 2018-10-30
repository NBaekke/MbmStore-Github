using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Movie : Product
    // derived class af product
    {
        // fields
        private string director;

        // properties
        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        // constructors
        public Movie()
        {
        }

        public Movie(int productID, string title, decimal price, string imageUrl, string director) : base(productID, title, price, imageUrl)
        {
            this.director = director;
        }
    }
}