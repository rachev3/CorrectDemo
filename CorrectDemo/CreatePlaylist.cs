using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrectDemo.InsideAccount;
using CorrectDemo.Models;

namespace CorrectDemo
{
    internal class CreatePlaylist
    {
        public static void Creation(int accId)
        {
            using (DataBase db = new DataBase())
            {
                Console.Clear();
                string chooseName = "Name of the Playlist:";
                Methods.CenterText(chooseName, 4, 1);
                Console.WriteLine(chooseName);
               

                Playlist playlist = new Playlist();
                Methods.CenterText(chooseName, 4, 2);
                playlist.Name = Console.ReadLine();

                var a = db.Users.Where(user => user.AccountId == accId).ToArray();
                a[0].Playlists.Add(playlist);
                db.SaveChanges();
            }
            AccountMenu.Menu(accId);
        }

    }
}
