using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class MusicCD : Product
    // derived class af product
    {
        // fields
        private List<Track> tracks = new List<Track>();
        private string artist;
        private string label;
        private short released;

        // properties
        public List<Track> Tracks
        {
            get { return tracks; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public string Label
        {
            get { return label; }
            set { label = value; }
        }

        public short Released
        {
            get { return released; }
            set { released = value; }
        }

        // constructors
        public MusicCD() { }

        public MusicCD(int productID, string title, string artist, decimal price, short released, string imageUrl) : base(productID, title, price, imageUrl)
        {
            this.artist = artist;
            this.released = released;
            tracks = new List<Track>();
        }

        public void addTrack(Track track)
        {
            tracks.Add(track);
        }

        public TimeSpan GetPlayingTime()
        {
            TimeSpan playingTime = new TimeSpan(0);
            foreach (Track track in tracks)
            {
                playingTime += track.Length;
            }
            return playingTime;
        }
        // Jeg udregner den samlede tidslængde et album her med angående antal numre
        // Jeg definerer den samlede tid til at være 0. Derefter laver jeg en foreach loop for at medregne alle numre.
    }
}
