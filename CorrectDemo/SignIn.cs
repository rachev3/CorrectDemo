using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrectDemo.InsideAccount;
using CorrectDemo.Models;

namespace CorrectDemo
{
    internal class SignIn
    {
        public static void LogIn()
        {
            using (DataBase db = new DataBase())
            {
                Console.Clear();

                string user = "Username:";

                Methods.CenterText(user, 5, 1);
                Console.WriteLine(user);
                Methods.CenterText(user, 5, 2);
                Console.WriteLine("".PadRight(user.Length, '_'));

                Methods.CenterText(user, 5, 4);
                Console.WriteLine("Парола:");
                Methods.CenterText(user, 5, 5);
                Console.WriteLine("".PadRight(user.Length, '_'));

                Methods.CenterText(user, 5, 2);
                string username = UsernameInput((Console.WindowWidth - user.Length) / 2, 15, "_");


                Methods.CenterText(user, 5, 5);
                string password = Methods.PasswordCover((Console.WindowWidth - user.Length) / 2, 18, "_");

                var a = db.Users.Where(user => user.Username == username && user.Password == password).ToArray();

                if (a.Length >= 1)
                {
                    AccountMenu.Menu(a[0].AccountId);
                }
                else
                {
                    Console.Clear();
                    string incorrect = "Incorrect username or password";
                    Methods.CenterText(incorrect, 1, 1);
                    Console.WriteLine(incorrect);
                    Thread.Sleep(2000);
                    MainMenu.Menu();
                }
            }
        }
        public static string UsernameInput(int left, int top, string deleteIndex)
        {
            string username = null;
            while (true)
            {
                var key = Console.ReadKey();
                int count = 0;
                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }
                if (key.Key == ConsoleKey.Backspace && username.Length > 0)
                {
                    username = username.Remove(username.Length - 1, 1);
                    left--;
                    Console.SetCursorPosition(left, top);
                    Console.Write(deleteIndex);
                }
                else if (key.Key == ConsoleKey.Backspace && username.Length == 0)
                {
                    Console.SetCursorPosition(left, top);
                    continue;
                }
                else
                {
                    username += key.KeyChar;
                    if (count == 0)
                    {
                        Console.SetCursorPosition(left + 1, top);
                        count++;

                    }
                    else
                    {
                        Console.SetCursorPosition(left, top);

                    }
                    left++;
                }
            }
            return username;
        }
    }

}
