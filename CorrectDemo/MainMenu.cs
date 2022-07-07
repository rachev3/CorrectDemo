using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectDemo
{
    internal class MainMenu
    {
        public static void Menu()
        {
            Console.Clear();
            PrintMainMenu();

            ConsoleKeyInfo button = default;
            ConsoleKeyInfo pressedKey;

            do
            {
                Console.SetCursorPosition(0, 0);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.CursorVisible = false;

                pressedKey = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Gray;

                if (pressedKey.Key == ConsoleKey.D1 || pressedKey.Key == ConsoleKey.D2)
                {
                    button = pressedKey;
                    PrintMainMenu(button.KeyChar - 48);
                }
                else if (pressedKey.Key != ConsoleKey.Enter)
                {
                    PrintMainMenu();
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
                CreateAccount.CreateAcc();
            }
            else if (button.Key == ConsoleKey.D2)
            {
                SignIn.LogIn();
            }
        }
        private static void PrintMainMenu(int button = -1)
        {
            string optionOne = "1) Create an account";
            string optionTwo = "2) Sign in";

            var defaultColor = ConsoleColor.Gray;
            var selectedColor = ConsoleColor.Cyan;

            Console.ForegroundColor = button == 1 ? selectedColor : defaultColor;
            Methods.CenterText(optionOne, 4, 1);
            Console.WriteLine(optionOne);

            Console.ForegroundColor = button == 2 ? selectedColor : defaultColor;
            Methods.CenterText(optionOne, 4, 2);
            Console.WriteLine(optionTwo);

            Console.ForegroundColor = defaultColor;
        }

    }
}
