namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
 

                Artiest artiest = new Artiest( null,null, "the man");
                Artiest artiest2 = new Artiest(null, null, "the women");
                Client client = new Client( null, null, null,null);
                Song song = new Song ("the titel", 9.23 ,"a gernre", artiest);
                Album album = new Album("titel", 9.28, null, null);
                album.Pause(song);

                Console.ReadLine(); 
            }


        }
    }


