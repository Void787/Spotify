namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
 

                Artiest artiest = new Artiest( null,null, "balls");
                Client client = new Client( null, null, null,null);
                Song song = new Song ("the titel", 9.23 ,"a gernre", artiest);
                client.Pause(song);

                Console.ReadLine(); 
            }
        }
    }


