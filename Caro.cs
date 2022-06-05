using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
    internal class GameOX
    {
        static char[] board = { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
        static int player = 1;
        static char playerchar1 = 'X';
        static char playerchar2 = '0';
                static void Main(string[] args)
                {
                    Console.WriteLine("======Lesson 2======");
                    Console.WriteLine("======  CARO  ======");
                    Console.WriteLine("player 1({0}) VS player 2({1})");
                    Board();
                }
            private static char getplayerchar(char c)
            {
                if (c == '-') { return ' '; }
                return c;
            }
        private static void Board()
        {
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", getplayerchar(board[1]), getplayerchar(board[2]), getplayerchar(board[3]));
            Console.WriteLine("-----+-----+-----");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", getplayerchar(board[4]), getplayerchar(board[5]), getplayerchar(board[6]));
            Console.WriteLine("-----+-----+-----");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", getplayerchar(board[7]), getplayerchar(board[8]), getplayerchar(board[9]));
        }
    }
}
























