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
        
        public String Title {
          get  { return title; }
          set { title = value; }
        }

        public double Playtime
        {
            get { return playtime; }
            set { playtime = value; }
        }
        public string Genre
        {
            get { return genre; }
            set { genre = value; }
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
           Console.WriteLine(this.title + " has stopped playing");


        }


        public void skip(Song song)
        {

        }
    }
}
