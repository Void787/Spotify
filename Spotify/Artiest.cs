using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Artiest
    {
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Album> albums = new List<Album>();
        private List<Song> Songs = new List<Song>();
        public ReadOnlyCollection<Album> albumen
        {
            get { return albums.AsReadOnly(); }
        }
        public ReadOnlyCollection<Song> nummers
        {
            get { return Songs.AsReadOnly(); }
        }

        public Artiest(Album albums, Song Songs, String Name) 
        {
            this.name = Name;
            this.albums.Add(albums);
            this.Songs.Add(Songs);
        
        }

        public void add_album(Album album)
        {

        }

        public void Show_album(Album album)
        {

        }
        public void Show_nr(Song song)
        {

        }

    }
}
