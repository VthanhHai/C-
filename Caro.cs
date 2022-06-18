using System;

namespace Tic_tac_toe
{
    class Caro
    {
        static char[] board = { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-' };
        static int player = 1;
        static char playerchar1 = 'X';
        static char playerchar2 = 'O';
        static int pos;
        static void Main(string[] args)
        {

            do
            {
                Board();
                Console.WriteLine("Toi luot player {0}:", getchar());
                pos = Convert.ToInt32(Console.ReadLine());
                CheckPosition();
                int flag = checkwin();
                if (flag == 1)
                {
                    Board();
                    Console.WriteLine("Player {0} thang!!, nhan phim bat ky de choi lai", playerwin());
                    Console.ReadLine(); ResetGame();

                }
                if (flag == -1)
                {
                    Board();
                    Console.WriteLine("Hoa!!, nhan phim bat ky de choi lai");
                    Console.ReadLine(); ResetGame();
                }

            } while (true);
        }
        private static char getplayerchar(char c)
        {
            if (c == '-')
            {
                return ' ';
            }
            return c;
        }
        private static void Board()
        {
            Console.Clear();
            Console.WriteLine("Tic Toc Toe Ver 0.0");
            Console.WriteLine("Player1({0}) vs Player({1})", playerchar1, playerchar2);
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", getplayerchar(board[1]), getplayerchar(board[2]), getplayerchar(board[3]));
            Console.WriteLine("-----+-----+-----");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", getplayerchar(board[4]), getplayerchar(board[5]), getplayerchar(board[6]));
            Console.WriteLine("-----+-----+-----");
            Console.WriteLine("  {0}  |  {1}  |  {2} ", getplayerchar(board[7]), getplayerchar(board[8]), getplayerchar(board[9]));
        }
        private static char getchar()
        {
            return player % 2 != 0 ? playerchar1 : playerchar2;
        }
        private static void CheckPosition()
        {
            char c = board[pos];
            if (c == playerchar1 || c == playerchar2)
            {
                Console.WriteLine("Vi tri da dung");
                return;
            }
            board[pos] = getchar();
            player++;
        }
        private static int checkwin()
        {
            int i;
            for (i = 1; i <= 9; i++)
            {
                if (board[i] == '-')
                    break;
            }
            if (board[1] == board[2] && board[2] == board[3] && board[3] != '-')
                return 1;
            if (board[4] == board[5] && board[5] == board[6] && board[6] != '-')
                return 1;
            if (board[7] == board[8] && board[8] == board[9] && board[9] != '-')
                return 1;
            if (board[1] == board[4] && board[4] == board[7] && board[7] != '-')
                return 1;
            if (board[2] == board[5] && board[5] == board[8] && board[8] != '-')
                return 1;
            if (board[3] == board[6] && board[6] == board[9] && board[9] != '-')
                return 1;
            if (board[1] == board[5] && board[5] == board[9] && board[9] != '-')
                return 1;
            if (board[3] == board[5] && board[5] == board[7] && board[7] != '-')
                return 1;
            if (i > 9)
            {
                return -1;
            }
            return 0;
        }
        private static char playerwin()
        {
            player = player % 2 == 0 ? 1 : 2;
            return getchar();
        }
        private static void ResetGame()
        {
            for (int i = 1; i <= 9; i++)
            {
                board[i] = '-';
                player = 1;
            }
        }


    }


}

















