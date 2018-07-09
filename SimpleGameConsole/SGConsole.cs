using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    public class SGConsole
    {

        public static void Write(int x, int y, ConsoleColor color, String text)
        {
            Console.CursorLeft = x;
            Console.CursorTop = y;
            //Console.BackgroundColor = color;
            Console.ForegroundColor = color;

            Console.Write(text);
        }

        public static void WriteLine(ConsoleColor color, String text) {
            //Console.BackgroundColor = color;
            Console.ForegroundColor = color;

            Console.WriteLine(text);
        }

        public static void WriteLine(String text)
        {
            //Console.BackgroundColor = color;
            //Console.ForegroundColor = color;
            Console.ResetColor();

            Console.WriteLine(text);
        }

        public static void Clear()
        {
            //Cleans screen
            Console.Clear();
        }



    }
}
