namespace CorrectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataBase())
            {
                //Account newAcc = new Account();
                //newAcc.Password = "123";
                //newAcc.Name = "az";
                //newAcc.Username = "az";       
                //db.Users.Add(newAcc);
                var a = db.Users.Where(user => "az" == "az").ToArray();

                Playlist playlist = new Playlist();
                playlist.Name = "d";
                // playlist.Songs = new List<Song>();
                
                
                

                // a[2].Playlists.Add(playlist);
                //var b = db.Songs.Where(song => "BOOM" == "BOOM").ToArray();
                //playlist.Songs.Add(b[1]);
                
                Song demo = new Song();
                demo.Artist = "Selected";
                demo.SongName = "Not Letting Go";
                demo.Genre = "House";
                demo.Url = "abc";
               // demo.Playlists = new List<Playlist>();
                db.Songs.Add(demo);

                playlist.Songs.Add(demo);
                demo.Playlists.Add(playlist);
                db.SaveChanges();

            }
        }
    }
}