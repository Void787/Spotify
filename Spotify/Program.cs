namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
 

                Artiest artiest = new Artiest( null,null, "the man");
                Client client = new Client( null, null, null,null);
                Song song = new Song ("the titel", 9.23 ,"a gernre", artiest);
                Playlist playlist = new Playlist("the women", 9.55,null,null,null);
                Album album = new Album("titel", 9.28, null, null);
                playlist.Pause(song);

                Console.ReadLine(); 
            }


        }
    }


