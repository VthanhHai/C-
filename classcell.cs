using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    class Cell
    {
        private int[,] cell = new int[3, 3];
        private ConsoleColor bg, fg;
        private int x, y;
        public int Y
        {
            get { return y; }
            set
            {
                Clear();
                y = value;
                Draw();
            }
        }
        public int X
        {
            get { return x; }
            set
            {
                Clear();
                x = value;
                Draw();
            }
        }
        public Cell(ConsoleColor bg, ConsoleColor fg)
        {
            cell = new int[3, 3];
            x = 0;
            y = 0;
            this.bg = bg;
            this.fg = fg;
            cell = NextCell();
        }
        private int[,] NextCell() // xuất ngẫu nhiên các khối gạch 
        {
            int maxCell = 6;
            Random rnd = new Random();
            return GetCell(rnd.Next(maxCell));

        }
        private int[,] GetCell(int idx)// tọa khối gạch
        {
            //rút ngắn gon code.
            ArrayList DefaultCell = new ArrayList();
            DefaultCell.Add(new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } });
            DefaultCell.Add(new int[,] { { 1, 1, 1 }, { 0, 1, 0 }, { 0, 0, 0 } });
            DefaultCell.Add(new int[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } });
            DefaultCell.Add(new int[,] { { 1, 1, 1 }, { 0, 0, 0 }, { 0, 0, 0 } });
            DefaultCell.Add(new int[,] { { 0, 1, 1 }, { 1, 1, 0 }, { 0, 0, 0 } });
            DefaultCell.Add(new int[,] { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 1, 0 } });
            return (int[,])DefaultCell[idx];
        }
        /*
        switch (idx)
        {
            case 1: return DefaultCell1(); break;
            case 2: return DefaultCell2(); break;
            case 3: return DefaultCell3(); break;
            case 4: return DefaultCell4(); break;
            case 5: return DefaultCell5(); break;

        }
        return DefaultCell6();



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
        int[,] cell = { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } };
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
        int[,] cell = { { 1, 0, 0 }, { 1, 0, 0 }, { 1, 1, 0 } };
        return cell;
    }
        */
        /* private void Draw_()// vẽ khối gạch 
         {
             int y_ = y;
             for (int i = 0; i < 3; i++)
             {
                 for (int j = 0; j < 3; j++)
                 {
                     Console.SetCursorPosition(x + j, y_);
                     Console.Write("{0}", cell[i, j] == 0 ? ' ' : '#');
                 }
                 y_++;
             }
         }
         public void Draw()
         {
             Console.ForegroundColor = fg;
             Draw_();
         }
         public void Clear()
         {
             Console.BackgroundColor = bg;
             Draw_();
         }
        */

        public void Draw() // vẽ khối gạch  
        {
            int y_ = y;
            Console.ForegroundColor = fg;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(x + j, y_);
                    Console.Write("{0}", cell[i, j] == 0 ? ' ' : '#');
                }
                y_++;
            }
        }
        public void Clear() //đổi màu khối gạch cùng với màu nền khi rớt xuống 
        {
            int y_ = y;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.SetCursorPosition(x + j, y_);
                    Console.Write("{0}", cell[i, j] == 0 ? ' ' : '#');
                }
                y_++;
            }
        }
        public void Move()
        {

        }
        //tạo method mới;
        // xoay khối gạch
        const int N = 3;
        public void Rotate()
        {
            int[,] tmp = new int[N, N];// tạo mảng mới.
            for (int i = 0; i < N; i++)//cột
            {
                for (int j = 0; j < N; j++)//dòng
                {
                    tmp[j, N - 1 - i] = cell[i, j];
                }
            }
            cell = tmp;
        }
        private static void board()
        {
            Console.Clear();

        }

    }

}
