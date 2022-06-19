using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace xepgach
{
    internal class chuongtrinh
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            int x_old, y_old;
            Console.SetCursorPosition(x, y);// gán tọa độ cho game.
            Console.ForegroundColor = ConsoleColor.Red;//thay đổi màu chữ
            Console.WriteLine("10");
            Console.BackgroundColor = ConsoleColor.Black;//thay đổi phông nền
            do
            {
                x_old = x;y_old = y;
                ConsoleKeyInfo banphim;// khai báo nút di chuyển
                banphim = Console.ReadKey();
                if (banphim.Key == ConsoleKey.Escape)// gán nút Exit game.
                    break;
                switch (banphim.Key)
                {
                    //gán nút di chuyển.
                    case ConsoleKey.LeftArrow:x--; break;
                        
                    case ConsoleKey.RightArrow:x++; break;
                        
                    case ConsoleKey.UpArrow:y--; break;
                        
                    case ConsoleKey.DownArrow:y++; break;
                        
                }

                //Console.Clear();
                Console.ForegroundColor= ConsoleColor.Black;//chùng với màu nền.
                Console.SetCursorPosition(x_old, y_old); // old tọa độ cũ 
                Console.WriteLine("10");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(x,y);
                Console.WriteLine("10");


            } while (true);

        }
    }
}
