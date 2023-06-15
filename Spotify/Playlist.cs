using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Spotify
{
    internal class Playlist
    {
        private List<Song> Songs = new List<Song>();
        private List<Album> Albums = new List<Album>();
        private Users user = new Users();
        private String title;
        private Double playtime;
        public ReadOnlyCollection<Song> nummers
        {
            get { return Songs.AsReadOnly(); }
        }
        public ReadOnlyCollection<Album> albums
        {
            get { return Albums.AsReadOnly(); }
        }
        public Users user
        {
            get { return name; }
            set { name = value; }
        }
        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        public double Playtime
        {
            get { return playtime; }
            set { playtime = value; }
        }

        public void Play(Song song)
        {

        }

    }
}
