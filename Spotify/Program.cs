namespace Spotify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            try
            {
                
            } catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }


            Song song = new Song("",2,"", new Artiest());

            song.Title = "New song";
            foreach(Artiest a in song.Artiesten)
            {
                Console.WriteLine(a.name);
            }
        }
    }
}