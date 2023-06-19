using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Song
    {
        private bool play;
        private List<Artiest> artiest = new List<Artiest>();     
        private string title;
        private double playtime;
        private String genre;
        public Song(Artiest artiest, string title, double playtime, string genre)
        {
            this.artiest.Add(artiest);
            this.title = title;
            this.playtime = playtime;
            this.genre = genre;
        }
        public String Title {
          get  { return title; }
          set { title = value; }
        }
        public String Play
        {
            get { return play; }
            set { play = value; }
        }
        public double Playtime
        {
            get { return Playtime; }
            set { Playtime = value; }
        }
        public String Genre
        {
            get { return Genre; }
            set { Genre = value; }
        }
        public ReadOnlyCollection<Artiest> Artiesten
        {
            get { return artiest.AsReadOnly(); }
        }
        public Song(String Title, double Playtime, string Genre, Artiest artiest) {
            this.title = Title;
            this.playtime = Playtime;
            this.genre = Genre;
            this.artiest.Add(artiest);
        }

        public void Play()
        {

        }

        public void Pause()
        {
            console.WriteLine(song.title + " has stoppend playing")

        }
 

            public void skip(Song song)
        {

        }
    }
}
