using System;
using System.Collections.Generic;
namespace Snake
{
    class Program
    {
        public class Snake// tạo hình con rắn
        {
            public Snake()
            {
                this.head = new point(0,0);
                // về sau chung ta sẽ cho rắn có độ dài là 3 *.
                this.body = new List<point>{};
            }
            public point head{get;set;}//đầu rắn
            public List<point> body{get;set;}// thân rắn 
        }
        public class food //tạo thức ăn cho rắn
        {
            public food()
            {

            }
            // size
            public int size;//{get;set;}
            public point point{get;set;}

        }
        public class point // tạo máp cho trò chơi 
        {
            public point()
            {

            }
            public point(int row,int column)
            {
                 this.Row = row;
                 this.Column=column;
            }
            public int Row {get;set;}
            public int Column{get;set;}
        }
        // máp trò chơi 
        // khai báo độ rộng trong máp trò chơi.
        static int N = 10;
        static int M = 10;
        static string gach = " # ";
        static string space= "   ";
        static string[,]board = new string[N,M];
        //tính toán vị trí của tường.
        private static void calcwall() 
        {
             for( int i = 0;i<N;i++)
             {
                for(int j = 0;j<M;j++)
                {
                    if(i==0 || i ==N-1|| j==0||j==M-1)
                    {
                        
                        board[i,j] = gach;
                    }
                }
             }
        }
        // khởi tạo lại giá trị ban đầu trong máp trò chơi bằng phí space.
        private static void resetboarđ()
        {
            for( int i = 0;i<N;i++)
             {
                for(int j = 0;j<M;j++)
                {
                    board[i,j]= " ";
                }
                Console.WriteLine();
             }
        }
        // in ra dữ liệu trong board ra màn hình 
        private static void printBoard()
        {
            for( int i = 0;i<N;i++)
             {
                for(int j = 0;j<M;j++)
                {
                    string value = board[i,j];
                    
                    if(value.Equals(gach))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write(value);
                        Console.ResetColor();
                    }else{
                        Console.Write(value);
                    }
                }
                Console.WriteLine();
             }
        }
        static void Main(string[]args)
        {   
            // draw wall.

            //draw snake.

            // draw food.

            // rắn chạm vào thức ăn thì dài ra 

            // rắn chạm vào thân thì phải chết 

            // tốc độ rắn tăng sau khi dài ra.



        }
    }
}