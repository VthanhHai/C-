using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

/* readkey
 * key info
 * background()
 * Console.ForegroundColor
 */

namespace Tetris
{
    internal class xepgach
    {




        static void Main(string[] args)

        {
            tetris game = new tetris();
            game.run();
            //cell.Draw();


        /*
        Console.ForegroundColor = ConsoleColor.Green;//doi mau chu

        int x = 0, y = 0;
        int x_old, y_old;
        Console.SetCursorPosition(x, y);//toa do
        Console.WriteLine("***");
        Console.WriteLine("***");
        Console.WriteLine("***");
        Console.BackgroundColor = ConsoleColor.Black;// đổi màu nền.
        do
        {
            x_old = x; y_old = y;
            ConsoleKeyInfo banphim;
            banphim = Console.ReadKey();//gan nut
            if (banphim.Key == ConsoleKey.Escape) //escape
                break;
            switch (banphim.Key)
            {
                case ConsoleKey.LeftArrow: x--; break;
                case ConsoleKey.RightArrow: x++; break;
                case ConsoleKey.UpArrow: y--; break;
                case ConsoleKey.DownArrow: y += 2; break;
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(x_old, y_old);
            Console.WriteLine("***");
            Console.WriteLine("***");
            Console.WriteLine("***");
            Console.ForegroundColor = ConsoleColor.Green;//doi mau chu
            Console.SetCursorPosition(x, y);
            Console.WriteLine("***");
            Console.WriteLine("***");
            Console.WriteLine("***");

        } while (true);
        */
        }
    }
    
}
