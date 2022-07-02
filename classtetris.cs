using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class tetris
    {
        public void run()
        {
            var readkeys = new Task(Readkeys);
            readkeys.Start();

            var animation = new Task(Animation);
            animation.Start();

            var tarks = new[] { readkeys };
            Task.WaitAll(tarks);
            // khí nhấn nút Escape thoat or tự dải phóng toàn bộ nhớ
            Console.CancelKeyPress += (Cender, e) =>
            {
                Environment.Exit(0);
            };
        }
        public tetris()
        {
            cell = new(ConsoleColor.Black, ConsoleColor.Red);
        }
        private Cell cell;
        private void Readkeys()// tạo bàn phím trong game 
        {
            ConsoleKeyInfo banphim = new ConsoleKeyInfo();
            while (!Console.KeyAvailable && banphim.Key != ConsoleKey.Escape) //key chưa sẵn sàng
            {
                banphim = Console.ReadKey(true);
                switch (banphim.Key)
                {
                    case ConsoleKey.LeftArrow: cell.X--; break; // nút sang trái.
                    case ConsoleKey.RightArrow: cell.X++; break; // nút sang phải.
                    case ConsoleKey.UpArrow: cell.Rotate(); break;// nút lên. 
                    case ConsoleKey.DownArrow: cell.Y = cell.Y += 3; break;// nút xuống. 
                }
            }

        }
        private void Animation() // khởi tạo cho khối gạch tự động rớt xuống 
        {
            for (; ; )
            {
                Thread.Sleep(1000);
                cell.Y = cell.Y + 1;

            }
        }
    }

}
