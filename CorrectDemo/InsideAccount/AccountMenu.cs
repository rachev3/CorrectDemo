using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectDemo.InsideAccount
{
    internal class AccountMenu
    {
        public static void Menu(int accId)
        {
            Console.Clear();
            PrintAccountMenu();

            ConsoleKeyInfo button = default;
            ConsoleKeyInfo pressedKey;

            do
            {
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.CursorVisible = false;

                pressedKey = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (pressedKey.Key == ConsoleKey.D1 || pressedKey.Key == ConsoleKey.D2 || pressedKey.Key == ConsoleKey.D3)
                {
                    button = pressedKey;
                    PrintAccountMenu(button.KeyChar - 48);
                }
                else if (pressedKey.Key != ConsoleKey.Enter)
                {
                    PrintAccountMenu();
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
                Console.ReadKey();
            }
            else if (button.Key == ConsoleKey.D2)
            {
                CreatePlaylist.Creation(accId);
            }
            else if (button.Key == ConsoleKey.D3)
            {
                AdjustPlaylist.Playlist(accId);
            }
        }
        private static void PrintAccountMenu(int button = -1)
        {
            string optionOne = "1) Your Playlists";
            string optionTwo = "2) Create PLaylist";
            string optionThree = "3) Adjust Playlist";

            var defaultColor = ConsoleColor.Gray;
            var selectedColor = ConsoleColor.Cyan;

            Console.ForegroundColor = button == 1 ? selectedColor : defaultColor;
            Methods.CenterText(optionOne, 5, 1);
            Console.WriteLine(optionOne);

            Console.ForegroundColor = button == 2 ? selectedColor : defaultColor;
            Methods.CenterText(optionOne, 5, 2);
            Console.WriteLine(optionTwo);

            Console.ForegroundColor = button == 3 ? selectedColor : defaultColor;
            Methods.CenterText(optionOne, 5, 3);
            Console.WriteLine(optionThree);

            Console.ForegroundColor = defaultColor;
        }

    }
}
