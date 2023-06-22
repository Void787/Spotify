using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    internal class Users
    {
        private String name;
        public String Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Playlist> playlist = new List<Playlist>(); 
        private List<Users> Friend = new List<Users>();
        public ReadOnlyCollection<Playlist> playlisten
        {
            get { return playlist.AsReadOnly(); }
        }
        public ReadOnlyCollection<Users> user
        {
            get { return Friend.AsReadOnly(); }
        }
      
        public Users(String Name,Playlist playlist, Users Friend) {
            this.name = Name;
            this.Friend.Add(Friend);
            this.playlist.Add(playlist);
        }
        public void Addfriend(Users friend)
        {
            
        }
        public void Removefriend(Users friend)
        {

        }
        public void  Showfriends(List<Users> friend)
        {
            foreach (Users user in friend)
            {
                Console.WriteLine(user.Name);
            }
        }
        public void Showplaylist(List<Playlist> playlist)
        {

        }
        public void Showsongs(List<Song> songs) { }

        public List<Song> Add_nr_to_playlist(List<Playlist> playlist)
        {
            List<Song> songs = new List<Song>();
            // Add songs to the list
            // Example: songs.Add(new Song(...));

            return songs;
        }


        public void Add_Playlist(List<Playlist> playlist)
        {

        }
        public void Select_nr(Song nummer)
        {

        }

/*        public Playlist Select_Playlist()

        {
*//*            Playlist playlist = new Playlist();*//*

            return playlist;
        }*/

    }

}
