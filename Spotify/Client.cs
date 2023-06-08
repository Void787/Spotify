using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Client
    {
        public List<Song> songs = new List<Song>();
        public List<Users> users = new List<Users>();
        public List<Album> albums = new List<Album>();
        public List<Playlist> playlist = new List<Playlist>();

        public Client() { }

        public void Play()
        {

        }
        public void Stop() {
        
        }
        public void Select_nr(int nr)
        {
            Song song = new Song();
        }
        public void Select_Playlist(Playlist playlist)
        {
            foreach (Song song in playlist)
            {
                Song song2 = new Song();
            }

        }
        public void Delete_nr(int nr, Playlist playlist)
        {

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
        public void ShowContent(List<Song>, List<Album>, List<Playlist>)
        {

        }
        public void Add_album_to_playlist(Album album Playlist playlist)
        {
            albums.Add(album);
        }
    }
}
