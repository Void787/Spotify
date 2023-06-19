using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Playble
    {
        private bool play;


        private string title;
        private double playtime;
        public String Title
        {
            get { return title; }
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
            console.WriteLine(song.title + " has stoppend playing")

        }

        public void skip(Song song)
        {

        }

        public void shuffle(Song song)
        {

        }
    }
}
