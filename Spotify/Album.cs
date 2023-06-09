﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Album 
    {
        private string title;
        private double playtime;
        private List<Artiest> artiest = new List<Artiest>();
        private List<Song> song = new List<Song>(); 


        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        // pak de sum van alle songs in album om de tijd te berekenen
        public double Playtime
        {
            get
            {
                foreach (Song song in Songs)
                {
                    playtime += song.Playtime;
                }
                return playtime;
            }

        }
        public ReadOnlyCollection<Artiest> Artiesten
        {
            get { return artiest.AsReadOnly(); }
        }

        public ReadOnlyCollection<Song> Songs 
        { 
            get { return song.AsReadOnly(); } 
        }
        public Album(string Title, double Playtime, List<Artiest> artiest, List<Song> song)
        {
            this.title = Title;
            this.playtime = Playtime;
            this.artiest = artiest;
            this.song = song;
        }
        public void Play(Song song)
        {
            Console.WriteLine("now playing: " + song.Title);
        }
        public void Pause(Song song)
        {
           Console.WriteLine(song.Title + " has stopped playing");


        }
        public void shuffle(Playlist playlist, Album albums)
        {

        }
        public void skip(Song song)
        {

        }
        public void Show_nr(Song song)
        {

        }

        public void Show_album(Album album)
        {

        }

        public void Select_nr(Song song)
        {

        }

        public void Select_album(Album album)
        {

        }

        public void Add_nr_playlist(Playlist playlist, Song Songs)
        {
            
        }

        public void Add_album_playlist(Album album)
        {

        }


    }
}
