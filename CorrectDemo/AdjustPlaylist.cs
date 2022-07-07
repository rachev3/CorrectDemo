using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrectDemo.Models;

namespace CorrectDemo
{
    internal class AdjustPlaylist
    {
        public static void Playlist(int accId)
        {
            using (DataBase db = new DataBase())
            {
                Console.Clear();
                string question = "Which playlist do you want to Adjust?";
                Methods.CenterText(question, 4, 1);
                Console.WriteLine(question);

                string name = Console.ReadLine(); 
                var a = db.Users.Where(user => user.AccountId == accId).ToArray();
               // a[0].Playlists.Where(plalist =);
            }
        }
        public static void AdjustMenu(int accId)
        {
            Console.Clear();
            PrintAdjust();

            ConsoleKeyInfo button = default;
            ConsoleKeyInfo pressedKey;

            do
            {
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.CursorVisible = false;

                pressedKey = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (pressedKey.Key == ConsoleKey.D1 || pressedKey.Key == ConsoleKey.D2 || pressedKey.Key == ConsoleKey.D3 || pressedKey.Key == ConsoleKey.D4)
                {
                    button = pressedKey;
                    PrintAdjust(button.KeyChar - 48);
                }
                else if (pressedKey.Key != ConsoleKey.Enter)
                {
                    PrintAdjust();
                    button = default;
                }
            }
            while (pressedKey.Key != ConsoleKey.Enter);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.CursorVisible = true;

            if (button == default)
            {
                throw new Exception("There is no option selected");
            }
            else if (button.Key == ConsoleKey.D1)
            {
                //AddSongToPlaylist.AddSong();
            }
            else if (button.Key == ConsoleKey.D2)
            {
                Console.ReadKey();
            }
            else if (button.Key == ConsoleKey.D3)
            {
                Console.ReadKey();
            }
            else if(button.Key == ConsoleKey.D4)
            {
                Console.ReadKey();
            }
        }
        private static void PrintAdjust(int button =-1)
        {
            string optionOne = "1) Add song";
            string optionTwo = "2) Remove song";
            string optionThree = "3) See songs";
            string optionFour = "4) Filter genre";

            var defaultColor = ConsoleColor.Gray;
            var selectedColor = ConsoleColor.Cyan;

            Console.ForegroundColor = button == 1 ? selectedColor : defaultColor;
            Methods.CenterText(optionOne, 6, 1);
            Console.WriteLine(optionOne);

            Console.ForegroundColor = button == 2 ? selectedColor : defaultColor;
            Methods.CenterText(optionOne, 6, 2);
            Console.WriteLine(optionTwo);

            Console.ForegroundColor = button == 3 ? selectedColor : defaultColor;
            Methods.CenterText(optionOne, 6, 3);
            Console.WriteLine(optionThree);

            Console.ForegroundColor = button == 4 ? selectedColor : defaultColor;
            Methods.CenterText(optionOne, 6, 4);
            Console.WriteLine(optionFour);

            Console.ForegroundColor = defaultColor;
        }
    }
}
