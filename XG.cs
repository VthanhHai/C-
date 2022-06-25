using System;
using System.Collections.Generic;

/* readkey
 * key info
 * background()
 * Console.ForegroundColor
 */

namespace Tetris
{
    class Cell
    {
        private int[,] cell;
        private ConsoleColor bg, fg;
        private int x, y;

        public Cell(ConsoleColor bg, ConsoleColor fg)
        {
            cell = new int[3, 3];
            x = 0;
            y = 0;
            this.bg = bg;
            this.fg = fg;
            cell = NextCell();
        }
        private int[,] NextCell()
        {
            int maxCell = 6;
            Random rnd = new Random();
            return GetCell(rnd.Next(maxCell) + 1);

        }
        private int[,] GetCell(int idx)
        {
            switch (idx)
            {
                case 1: return DefaultCell1(); break;
                case 2: return DefaultCell2(); break;
                case 3: return DefaultCell3(); break;
                case 4: return DefaultCell4(); break;
                case 5: return DefaultCell5(); break;

            }
            return DefaultCell6();
        }
        private int[,] DefaultCell1()
        {
            int[,] cell = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            return cell;
        }
        private int[,] DefaultCell2()
        {
            int[,] cell = { { 1, 1, 1 }, { 0, 1, 0 }, { 0, 0, 0 } };
            return cell;
        }
        private int[,] DefaultCell3()
        {
            int[,] cell = { { 1, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            return cell;
        }
        private int[,] DefaultCell4()
        {
            int[,] cell = { { 1, 1, 1 }, { 0, 0, 0 }, { 0, 0, 0 } };
            return cell;
        }
        private int[,] DefaultCell5()
        {
            int[,] cell = { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 1 } };
            return cell;
        }
        private int[,] DefaultCell6()
        {
            int[,] cell = { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 1, 1 } };
            return cell;
        }
        public void Draw()
        {
            int y_ = y;
            Console.ForegroundColor = fg;
            for (int i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(x + j, y_ +);
                    Console.Write("{0}", cell[i, j] == 0 ? ' ' : '*');
                }
            }
        }
        public void Clear()
        {

        }
        public void Move()
        {

        }
    }
    internal class xepgach
    {
        

        static void Main(string[] args)

        {
            Cell cell = new(ConsoleColor.Green, ConsoleColor.Red);
            cell.Draw();
            Console.ForegroundColor = ConsoleColor.Green;//doi mau chu

            int x = 0, y = 0;
            int x_old, y_old;
            Console.SetCursorPosition(x, y);//toa do
            Console.WriteLine("***");
            Console.WriteLine("***");
            Console.WriteLine("***");
            Console.BackgroundColor = ConsoleColor.Black;
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

        }
    }
}