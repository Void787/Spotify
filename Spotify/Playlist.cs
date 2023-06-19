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
        private Users user;
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
        public Users Owner
        {
            get { return user; }
        }
        public String Title
        {
            get { return title; }
            set { title = value; }
        }
        public double Playtime
        {
            get { foreach (Song song in Songs)
                {
                    playtime += song.Playtime;
                } 
                return playtime; }

        }
        public Playlist( String Title, double Playtime, Users Owner, Album Albums, Song Songs ) 
        {
            this.playtime = Playtime;
            this.title = Title;
            this.Albums.Add(Albums);
            this.Songs.Add(Songs);
            this.user = Owner;
        }

        public void Play()
        {

        }

        public void Pause(Song song)
        {
            Console.WriteLine(song.Title + " has stopped playing");

        }

        public void Delete_nr(int nr, Playlist playlist)
        {

        }

        public void Add_nr_playlist(Playlist playlist, Song songs)
        {

        }

        public void skip(Song song)
        {

        }

        public void shuffle(Song song)
        {

        }
        public void Show_playlist( Playlist playlist)
        {

        }

        public void Select_nr(Song Song)
        {

        }

    }
}
