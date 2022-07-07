using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrectDemo.Models;

namespace CorrectDemo
{
    internal class CreateAccount
    {
        public static void CreateAcc()
        {
            using (DataBase db = new DataBase())
            {
                Console.Clear();
                Account user = new Account();

                Console.WriteLine("Username:");
                user.Username = Console.ReadLine();

                Console.WriteLine("Password:");
                user.Password = Methods.PasswordCover(0, 3, " ");

                Console.WriteLine("Name:");
                user.Name = Console.ReadLine();

                db.Users.Add(user);
                db.SaveChanges();

                MainMenu.Menu();
            }
        }

    }
}
