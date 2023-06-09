﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Client
    {
        private bool play;
        private List<Song> songs = new List<Song>();
        private List<Users> users = new List<Users>();
        private List<Album> albums = new List<Album>();
        private List<Playlist> playlist = new List<Playlist>();

        public ReadOnlyCollection<Song> nummers
        {
            get { return songs.AsReadOnly(); }
        }
        public ReadOnlyCollection<Users> gebruikers
        {
            get { return users.AsReadOnly(); }
        }
        public ReadOnlyCollection<Album> album
        {
            get { return albums.AsReadOnly(); }
        }
        public ReadOnlyCollection<Playlist> playlisten
        {
            get { return playlist.AsReadOnly(); }
        }

        public Client( Song songs, Users users, Album albums, Playlist playlist)
        {

            this.albums.Add(albums);
            this.users.Add(users);
            this.songs.Add(songs);
            this.playlist.Add(playlist);
        }

        public void Play(Song song)
        {
            Console.WriteLine("now playing: " + song.Title);
        }
        public void Pause(Song song)
        {
            Console.WriteLine(song.Title + " has stopped playing");


        }


        public void Select_nr(int nr)
        {

        }
        public void Select_Playlist(Playlist playlist)
        {


        }
        public void Delete_nr(Song songs Playlist playlist)
        {
            playlist.Delete_nr_playlist(songs);
        }
        public void Delete_Playlist(Playlist playlist)
        {
            
        }
        public void Nextpage(int nr)
        {

        }
        public void Prevpage(int nr)
        {

        }
        public void shuffle(Playlist playlist, Album albums)
        {

        }
        public void skip(Song song)
        {

        }
        public void ShowContent(List<Song> songs, List<Album> albums, List<Playlist> playlists)
        {

        }
        public void Add_album_to_playlist(Album album, Playlist playlist)
        {
            albums.Add(album);
        }
        public void Add_nummer_to_playlist(Song song, Playlist playlist)
        {
                playlist.Add_nr_playlist(song);
        }
    }
}
