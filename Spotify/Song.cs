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
        public String Title {
          get  { return title; }
          set { title = value; }
        }
        private string title;
        private double Playtime
        {
            get { return Playtime; }
            set { Playtime = value; }
        }
        private String Genre
        {
            get { return Genre; }
            set { Genre = value; }
        }
        public ReadOnlyCollection<Artiest> Artiesten
        {
            get { return artiest.AsReadOnly(); }
        }
        private List<Artiest> artiest = new List<Artiest>();

        public Song(String Title, double Playtime, string Genre, Artiest artiest) {
            this.title = Title;
            this.Playtime = Playtime;
            this.Genre = Genre;
            this.artiest.Add(artiest);
        }
    }
}
