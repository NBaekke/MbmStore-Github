using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Track
    {
        // fields
        private string title;
        private string composer;
        private TimeSpan length;

        // properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Composer
        {
            get { return composer; }
            set { composer = value; }
        }

        public TimeSpan Length
        {
            get { return length; }
            set { length = value; }
        }

        // constructors
        public Track(string title, string composer, TimeSpan length)
        {
            this.title = title;
            this.composer = composer;
            this.length = length;
        }
    }
}
