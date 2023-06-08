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
    }
}
