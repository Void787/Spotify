namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double playtime = 3.17;
            Artiest artiest = new Artiest(null, null, "The Baseballs"); ;
            Song song = new Song(artiest, "california girls", playtime, "pop");
            Client client = new Client(null, null, null, null);

            client.Play(song);
        }
    }
}