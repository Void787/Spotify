using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playble
    {



        private string title;
        private double playtime;
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


        public Playble(string Title, double Playtime)
        {
            title = Title;
            playtime = Playtime;

        }

        public void Play(Song song)
        {
            Console.WriteLine("now playing: " + song.Title);
        }

        public void Pause()
        {
            Console.WriteLine(this.title + " has stopped playing");


        }

        public void skip(Song song)
        {

        }

        public void shuffle(Song song)
        {

        }
    }
}
