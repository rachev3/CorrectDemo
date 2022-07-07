using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectDemo
{
    internal class Methods
    {
        public static void CenterText(string text, int height, int rows = 0)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, (Console.WindowHeight - height) / 2 + rows);
        }
        public static string PasswordCover(int left, int top, string deleteIndex)
        {
            string password = null;

            while (true)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine();
                    break;
                }
                if (key.Key == ConsoleKey.Backspace && password.Length > 0)
                {
                    password = password.Remove(password.Length - 1, 1);
                    left--;
                    Console.SetCursorPosition(left, top);
                    Console.Write(deleteIndex);
                }
                else if (key.Key == ConsoleKey.Backspace && password.Length == 0)
                {
                    Console.SetCursorPosition(left, top);
                    continue;
                }
                else
                {
                    password += key.KeyChar;
                    Console.SetCursorPosition(left, top);
                    Console.Write('*');
                    left++;
                }
            }
            return password;
        }
    }
}
